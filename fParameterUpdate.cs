using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.Controller;

namespace Hotel_Management
{
    public partial class fParameterUpdate : Form
    {
        ParameterController controller = new ParameterController();

        public fParameterUpdate()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            dgvDanhSachQuyDinh.DataSource = controller.getAll();
            txtHeSoKHNuocNgoai.Text = controller.HESOKHNUOCNGOAI().ToString();
            txtPhuThu.Text = controller.PHUTHU().ToString();
            txtSoKHToiDa1Phong.Text = controller.SOKHTOIDA1PHONG().ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            THAMSO thamso = new THAMSO()
            {
                SOKHTOIDA1PHONG = Convert.ToInt32(txtSoKHToiDa1Phong.Text),
                PHUTHU = Convert.ToDecimal(txtPhuThu.Text),
                HESOKHNUOCNGOAI = Convert.ToInt32(txtHeSoKHNuocNgoai.Text)
            };

            controller.updateParameter(thamso);
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
