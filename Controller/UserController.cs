using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class UserController
    {

        KHACHSANEntities entities = new KHACHSANEntities();

        public dynamic getAll()
        {
            var data = from c in entities.NGUOIDUNGs
                       select new
                       {
                           ID = c.MANGUOIDUNG,
                           Name = c.TENNGUOIDUNG,
                           Rights = c.QUYENTRUYCAP,
                           Avatar = c.ANHDAIDIEN
                       };
                       
            return data.ToList();
        }

        public NGUOIDUNG getUserByID(int ID)
        {
            return entities.NGUOIDUNGs.Find(ID);
        }

        public dynamic All()
        {
            var data =  entities.NGUOIDUNGs;
            return data.ToList();
        }

        public void UpdateUser(NGUOIDUNG nguoidung)
        {
            NGUOIDUNG p = entities.NGUOIDUNGs.Find(nguoidung.MANGUOIDUNG);
            p.TENNGUOIDUNG = nguoidung.TENNGUOIDUNG;
            p.TENDANGNHAP = nguoidung.TENDANGNHAP;
            //p.MATKHAU = nguoidung.MATKHAU;
            //p.QUYENTRUYCAP = nguoidung.QUYENTRUYCAP;
            entities.SaveChanges();
        }
        public void UpdatePassword(NGUOIDUNG nguoidung)
        {
            NGUOIDUNG p = entities.NGUOIDUNGs.Find(nguoidung.MANGUOIDUNG);
            p.MATKHAU = nguoidung.MATKHAU;
            entities.SaveChanges();
        }
        public void updateRights(NGUOIDUNG nguoiDung)
        {
            NGUOIDUNG p = entities.NGUOIDUNGs.Find(nguoiDung.MANGUOIDUNG);
            p.QUYENTRUYCAP = nguoiDung.QUYENTRUYCAP;

            entities.SaveChanges();
        }

        public void deleteUser(int ID)
        {
            NGUOIDUNG nd = entities.NGUOIDUNGs.Find(ID);
            if (nd != null)
            {

                entities.NGUOIDUNGs.Remove(nd);
                entities.SaveChanges();
            }
        }


        public void addUser(NGUOIDUNG nd)
        {
            entities.NGUOIDUNGs.Add(nd);
            entities.SaveChanges();
        }


        public void resetUser(NGUOIDUNG nguoidung)
        {
            NGUOIDUNG p = entities.NGUOIDUNGs.Find(nguoidung.MANGUOIDUNG);
            p.TENDANGNHAP = nguoidung.TENDANGNHAP;
            p.MATKHAU = nguoidung.MATKHAU;
            entities.SaveChanges();
        }

        public int login(string username, string password)
        {
            var existuser = entities.NGUOIDUNGs.FirstOrDefault(m => m.TENDANGNHAP.Equals(username));
            if(existuser != null)
            {
                if (existuser.MATKHAU.Equals(password))
                    return existuser.MANGUOIDUNG;
                else
                    return -1;
            }
            return -1;           
        }

        public void getData(NGUOIDUNG nguoidung)
        {
            int ID = nguoidung.MANGUOIDUNG;
            string name = nguoidung.TENNGUOIDUNG;
            int avatar = nguoidung.ANHDAIDIEN;
        }
    }
}
