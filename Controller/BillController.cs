using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class BillController
    {
        KHACHSANEntities entities = new KHACHSANEntities();

        public dynamic getAll()
        {
            var data = from c in entities.CHITIETHOADONs
                       orderby c.MAHOADON descending
                       select new
                       {
                           ID = c.MAHOADON,
                           PaymentDay = c.HOADON.NGAYTHANHTOAN,
                           Value = c.HOADON.TRIGIA,
                           RentalDays = c.SONGAYTHUE,
                           RoomName = c.PHONG.TENPHONG,
                           RoomID = c.PHONG.MAPHONG,
                           UnitPrice = c.DONGIA,
                           CustomerID = c.HOADON.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.HOADON.KHACHHANG.TENKHACHHANG,
                           Amount = c.THANHTIEN,
                           RentalID = c.MAPHIEUTHUE
                       };

            return data.ToList();
        }

        public dynamic getAllWithTime(int month, int year)
        {
            var data = from c in entities.CHITIETHOADONs
                       where c.HOADON.NGAYTHANHTOAN.Month == month && c.HOADON.NGAYTHANHTOAN.Year == year
                       select new
                       {
                           ID = c.MAHOADON,
                           PaymentDay = c.HOADON.NGAYTHANHTOAN,
                           Value = c.HOADON.TRIGIA,
                           RentalDays = c.SONGAYTHUE,
                           RoomName = c.PHONG.TENPHONG,
                           RoomType = c.PHONG.LOAIPHONG.TENLOAIPHONG,
                           RoomID = c.PHONG.MAPHONG,
                           UnitPrice = c.DONGIA,
                           CustomerID = c.HOADON.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.HOADON.KHACHHANG.TENKHACHHANG,
                           Amount = c.THANHTIEN,
                           RentalID = c.MAPHIEUTHUE
                       };
            //if (data.ToList().Count == 0)
            //    return new List<int>();
            return data.ToList();
        }

        public void addBill(HOADON hd, CHITIETHOADON cthd)
        {
            entities.HOADONs.Add(hd);
            entities.SaveChanges();
            cthd.MAHOADON = hd.MAHOADON;
            entities.CHITIETHOADONs.Add(cthd);
            entities.SaveChanges();
        }

        public void updateBill(HOADON hd, CHITIETHOADON cthd)
        {
            HOADON h = entities.HOADONs.Find(hd.MAHOADON);
            CHITIETHOADON c = entities.CHITIETHOADONs.Where(x => x.MAHOADON == hd.MAHOADON).SingleOrDefault();
            h.NGAYTHANHTOAN = hd.NGAYTHANHTOAN;
            h.TRIGIA = hd.TRIGIA;
            cthd.DONGIA = c.DONGIA;
            cthd.SONGAYTHUE = c.SONGAYTHUE;
            cthd.MAPHONG = c.MAPHONG;
            h.MAKHACHHANG = hd.MAKHACHHANG;
            entities.SaveChanges();
        }

        public void deleteBill(int ID)
        {
            HOADON hd = entities.HOADONs.Find(ID);
            if (hd != null)
            {
                CHITIETHOADON ct = entities.CHITIETHOADONs.Where(p => p.MAHOADON == ID).SingleOrDefault();
                entities.CHITIETHOADONs.Remove(ct);
                entities.HOADONs.Remove(hd);
                entities.SaveChanges();
            }
        }

        public dynamic findBill(int ID, string customerName, string roomName, string roomTypeName)
        {
            var result = from c in entities.CHITIETHOADONs
                         select c;
            if (ID != -1)
                result = from c in entities.CHITIETHOADONs
                         where c.MAHOADON == ID
                         select c;
            if (customerName != "")
                result = from c in result
                         where c.HOADON.KHACHHANG.TENKHACHHANG.Contains(customerName)
                         select c;
            if (roomName != "")
                result = from c in result
                         where c.PHONG.TENPHONG.Contains(roomName)
                         select c;
            if (roomTypeName != "")
                result = from c in result
                         where c.PHONG.LOAIPHONG.TENLOAIPHONG.Contains(roomTypeName)
                         select c;

            var data = from c in result
                       orderby c.MAHOADON descending
                       select new
                       {
                           ID = c.MAHOADON,
                           PaymentDay = c.HOADON.NGAYTHANHTOAN,
                           Value = c.HOADON.TRIGIA,
                           RentalDays = c.SONGAYTHUE,
                           RoomName = c.PHONG.TENPHONG,
                           RoomID = c.PHONG.MAPHONG,
                           UnitPrice = c.DONGIA,
                           CustomerID = c.HOADON.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.HOADON.KHACHHANG.TENKHACHHANG,
                           Amount = c.THANHTIEN,
                           RentalID = c.MAPHIEUTHUE
                       };

            return data.ToList();
        }

        public int getBillID(int RentalID)
        {
            CHITIETHOADON cthoadon = entities.CHITIETHOADONs.Where(c => c.MAPHIEUTHUE == RentalID).SingleOrDefault();
            //System.Windows.MessageBox.Show(RentalID + " ");// + cthoadon.MAHOADON);
            return (int) cthoadon.MAHOADON;
        }

        public CHITIETHOADON getBillByID(int BillID)
        {
            return entities.CHITIETHOADONs.Where(c => c.MAHOADON == BillID).SingleOrDefault();
        }

    }
}