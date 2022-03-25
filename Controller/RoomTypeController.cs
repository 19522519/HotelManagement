using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class RoomTypeController
    {
        KHACHSANEntities entities = new KHACHSANEntities();
        public dynamic getAll()
        {
            var data = from c in entities.LOAIPHONGs 
                       select new { ID = c.MALOAIPHONG, Name = c.TENLOAIPHONG, Price = c.DONGIA };
            return data.ToList();
        }
        public void AddRoomType(LOAIPHONG lp)
        {
            entities.LOAIPHONGs.Add(lp);
            entities.SaveChanges();
        }
        public void DeleteRoomType(int ID)
        {
            LOAIPHONG lp = new LOAIPHONG();
            if (lp != null)
            {
                lp = entities.LOAIPHONGs.Where(p => p.MALOAIPHONG == ID).SingleOrDefault();
                entities.LOAIPHONGs.Remove(lp);
                entities.SaveChanges();
            }

        }
        public void UpdateRoomType(LOAIPHONG lp)
        {
            LOAIPHONG l = entities.LOAIPHONGs.Find(lp.MALOAIPHONG);
            l.TENLOAIPHONG = lp.TENLOAIPHONG;
            l.DONGIA = lp.DONGIA;
            entities.SaveChanges();
        }
    }
}
