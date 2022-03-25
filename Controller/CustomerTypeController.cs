using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class CustomerTypeController
    {
        KHACHSANEntities entities = new KHACHSANEntities();
        public dynamic getAll()
        {
            var data = from c in entities.LOAIKHACHes
                       select new
                       {
                           ID = c.MALOAIKHACH,
                           Name = c.TENLOAIKHACH
                       };

            return data.ToList();
        }
        public void insertCustomerType(LOAIKHACH lk)
        {
            entities.LOAIKHACHes.Add(lk);
            entities.SaveChanges();
        }
        public void updateCustomerType(LOAIKHACH lk)
        {
            LOAIKHACH l = entities.LOAIKHACHes.Find(lk.MALOAIKHACH);
            l.TENLOAIKHACH = lk.TENLOAIKHACH;
            entities.SaveChanges();
        }
        public void deleteCustomer(int ID)
        {
            LOAIKHACH lk = entities.LOAIKHACHes.Find(ID);
            if (lk != null)
            {
                entities.LOAIKHACHes.Remove(lk);
                entities.SaveChanges();
            }
        }
    }
}