using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_Management.Controller
{
    class RentalController
    {
        KHACHSANEntities entities = new KHACHSANEntities();

        public dynamic getAll()
        {
            var data = from c in entities.CHITIETPHIEUTHUEs
                       orderby c.MAPHIEUTHUE descending
                       select new
                       {
                           ID = c.MAPHIEUTHUE,
                           RoomName = c.PHIEUTHUE.PHONG.TENPHONG,
                           CustomerID = c.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.KHACHHANG.TENKHACHHANG,
                           CMND = c.KHACHHANG.CMND,
                           DayStart = c.PHIEUTHUE.NGAYBDTHUE,
                           Address = c.KHACHHANG.DIACHI,
                           NOTE = c.PHIEUTHUE.GHICHU
                       };

            return data.ToList();
        }

        public void setPaid(int ID)
        {
            PHIEUTHUE phieuthue = entities.PHIEUTHUEs.Find(ID);
            phieuthue.GHICHU = "Đã thanh toán";
            entities.SaveChanges();
        }

        public int addRental(PHIEUTHUE pt)
        {
            entities.PHIEUTHUEs.Add(pt);
            entities.SaveChanges();
            return pt.MAPHIEUTHUE;
        }

        public void addRentalDetail(int MaPhieuThue, CHITIETPHIEUTHUE ctpt)
        {
            ctpt.MAPHIEUTHUE = MaPhieuThue;
            entities.CHITIETPHIEUTHUEs.Add(ctpt);
            entities.SaveChanges();
        }

        public void updateRental(PHIEUTHUE pt, CHITIETPHIEUTHUE ctpt)
        {
            PHIEUTHUE p = entities.PHIEUTHUEs.Find(pt.MAPHIEUTHUE);
            CHITIETPHIEUTHUE c = entities.CHITIETPHIEUTHUEs.Where(x => x.MAPHIEUTHUE == pt.MAPHIEUTHUE).SingleOrDefault();
            p.NGAYBDTHUE = pt.NGAYBDTHUE;
            p.MAPHONG = pt.MAPHONG;
            c.MAKHACHHANG = ctpt.MAKHACHHANG;           
            entities.SaveChanges();
        }

        public void deleteRental(int ID)
        {
            //MessageBox.Show("" + ID);
            PHIEUTHUE pt = entities.PHIEUTHUEs.Find(ID);
            if (pt != null)
            {
                CHITIETPHIEUTHUE ct = entities.CHITIETPHIEUTHUEs.Where(p => p.MAPHIEUTHUE == ID).SingleOrDefault();
                entities.CHITIETPHIEUTHUEs.Remove(ct);
                entities.PHIEUTHUEs.Remove(pt);
                entities.SaveChanges();
            }
        }

        public dynamic findRental(int ID, string customerName, string roomName)
        {
            var result = from c in entities.CHITIETPHIEUTHUEs
                         select c;
            if (ID != -1)
                result =  from c in entities.CHITIETPHIEUTHUEs
                         where c.MAPHIEUTHUE == ID
                         select c;
            if (customerName != "")
                result =  from c in result
                     where c.KHACHHANG.TENKHACHHANG.Contains(customerName)
                     select c;
            if (roomName != "")
                result = from c in result
                     where c.PHIEUTHUE.PHONG.TENPHONG.Contains(roomName)
                     select c;

            var data = from c in result
                       orderby c.MAPHIEUTHUE descending
                       select new
                       {
                           ID = c.MAPHIEUTHUE,
                           RoomName = c.PHIEUTHUE.PHONG.TENPHONG,
                           CustomerID = c.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.KHACHHANG.TENKHACHHANG,
                           CMND = c.KHACHHANG.CMND,
                           DayStart = c.PHIEUTHUE.NGAYBDTHUE,
                           Address = c.KHACHHANG.DIACHI,
                           NOTE = c.PHIEUTHUE.GHICHU
                       };

            return data.ToList();
        }

        public bool isForeign(int ID)
        {
            var data = from c in entities.CHITIETPHIEUTHUEs
                       where c.MAPHIEUTHUE == ID && c.KHACHHANG.LOAIKHACH.TENLOAIKHACH == "Nước ngoài" //:((
                       select c;
            //MessageBox.Show("" + data.ToList().Count);
            if (data.ToList().Count != 0)
                return true;
            return false;
        }

        public int getNumberPeople(int ID)
        {
            var data = from c in entities.CHITIETPHIEUTHUEs
                       where c.MAPHIEUTHUE == ID 
                       select c;

            return data.ToList().Count;
        }
    }
}
