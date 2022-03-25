using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class RoomController
    {
        KHACHSANEntities entities = new KHACHSANEntities();
        public dynamic getAll()
        {
            var data = from c in entities.PHONGs
                       select new
                       {
                           ID = c.MAPHONG,
                           Name = c.TENPHONG,
                           RoomType = c.LOAIPHONG.TENLOAIPHONG,
                           Price = c.LOAIPHONG.DONGIA,
                           Status = c.TINHTRANG,
                           Note = c.GHICHU,
                       };
            return data.ToList();
        }

        public void setRoomBooked(int ID)
        {
            PHONG phong = entities.PHONGs.Find(ID);
            phong.TINHTRANG = "Đóng";
            entities.SaveChanges();
        }

        public void setRoomCheck(int ID)
        {
            PHONG phong = entities.PHONGs.Find(ID);
            phong.TINHTRANG = "Mở";
            entities.SaveChanges();
        }

        public dynamic getAvaiableRoom()
        {
            var data = from c in entities.PHONGs
                       where c.TINHTRANG == "Mở"
                       select new
                       {
                           ID = c.MAPHONG,
                           Name = c.TENPHONG,
                           RoomType = c.LOAIPHONG.TENLOAIPHONG,
                           Price = c.LOAIPHONG.DONGIA,
                           Status = c.TINHTRANG,
                           Note = c.GHICHU
                       };
            return data.ToList();
        }

        public dynamic All()
        {
            var data = entities.LOAIPHONGs;
            return data.ToList();
        }
        public void AddRoom(PHONG p)
        {
            entities.PHONGs.Add(p);
            entities.SaveChanges();
        }
        public void DeleteRoom(int ID)
        {
            PHONG p = entities.PHONGs.Find(ID);
            if (p != null)
            {
                entities.PHONGs.Remove(p);
                entities.SaveChanges();
            }
        }
        public void UpdateRoom(PHONG p)
        {
            PHONG ph = entities.PHONGs.Find(p.MAPHONG);
            ph.MALOAIPHONG = p.MALOAIPHONG;
            ph.TENPHONG = p.TENPHONG;
            ph.GHICHU = p.GHICHU;
            ph.TINHTRANG = p.TINHTRANG;
            entities.SaveChanges();
        }

       

        public dynamic findRoom(string roomName, string roomTypeName)
        {
            var result = from c in entities.PHONGs
                         select c;
            if(roomName!="")
            {
                result = from c in result
                         where c.TENPHONG.Contains(roomName)
                         select c;
            }
            if (roomTypeName != "")
            {
                result = from c in result
                         where c.LOAIPHONG.TENLOAIPHONG.Contains(roomTypeName)
                         select c;
            }
            var value = from c in result
                        select new
                        {
                            ID = c.MAPHONG,
                            Name = c.TENPHONG,
                            RoomType = c.LOAIPHONG.TENLOAIPHONG,
                            Price = c.LOAIPHONG.DONGIA,
                            Status = c.TINHTRANG,
                            Note = c.GHICHU
                        };

            return value.ToList();

        }
    }
}

