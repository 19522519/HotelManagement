using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_Management.Controller
{
    class ParameterController
    {
        KHACHSANEntities entities = new KHACHSANEntities();

        public int HESOKHNUOCNGOAI()
        {
            var value =  from c in entities.THAMSOes
                        select c.HESOKHNUOCNGOAI;
            return value.FirstOrDefault();
        }

        public decimal PHUTHU()
        {
            var value = from c in entities.THAMSOes
                        select c.PHUTHU;
            return value.FirstOrDefault();
        }

        public int SOKHTOIDA1PHONG()
        {
            var value = from c in entities.THAMSOes
                        select c.SOKHTOIDA1PHONG;
            return value.FirstOrDefault();
        }

        public dynamic getAll()
        {
            return entities.THAMSOes.ToList();
        }

        public void updateParameter(THAMSO thamso)
        {
            THAMSO ts = entities.THAMSOes.FirstOrDefault();
            //MessageBox.Show("" + ts.HESOKHNUOCNGOAI);
            //entities.Entry(ts).CurrentValues.SetValues(thamso);
            //ts.SOKHTOIDA1PHONG = 5;
            entities.THAMSOes.Remove(ts);
            entities.SaveChanges();
            entities.THAMSOes.Add(thamso);
            entities.SaveChanges();          
        }
    }
}
