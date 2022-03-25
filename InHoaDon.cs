using Hotel_Management.Controller;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class InHoaDon : Form
    {
        BillController controller = new BillController();
        CHITIETHOADON cthoadon = new CHITIETHOADON();
        public InHoaDon(int billID)
        {
            InitializeComponent();
            cthoadon = controller.getBillByID(billID);

            txtTenKh.Text = cthoadon.HOADON.KHACHHANG.TENKHACHHANG.ToString();
            txtMaHoaDon.Text = cthoadon.HOADON.MAHOADON.ToString();
            dtpDay.Value = cthoadon.HOADON.NGAYTHANHTOAN;
            txtPrice.Text = cthoadon.HOADON.TRIGIA.ToString();

            txtMaCT.Text = cthoadon.MACHITIETHOADON.ToString();
            txtRoomName.Text = cthoadon.PHONG.TENPHONG;
            txtNumberDay.Text = cthoadon.SONGAYTHUE.ToString();
            txtUnitPrice.Text = cthoadon.DONGIA.ToString();
            txtMoney.Text = cthoadon.THANHTIEN.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //System.Drawing.Rectangle display1 = this.Bounds; // winforms control bounds
            // for full screen use "= Screen.GetBounds(Point.Empty);

            int WIDTH = this.Width - 30;
            int HEIGHT = this.Height - 140;
            var bm = new Bitmap(WIDTH, HEIGHT);
            //display1.DrawToBitmap(bm, display1.ClientRectangle);

            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(new System.Drawing.Point(this.Location.X + 10, this.Location.Y + 30), System.Drawing.Point.Empty, new Size( WIDTH, HEIGHT));

            var dlg = new SaveFileDialog { DefaultExt = "png", Filter = "Png Files|*.png" };
            var res = dlg.ShowDialog();
            if (res == DialogResult.OK) bm.Save(dlg.FileName, ImageFormat.Png);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
