using Hotel_Management.Controller;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class fReport : Form
    {
        RoomTypeController roomTypeController = new RoomTypeController();
        BillController billController = new BillController();
        //DataGridView data = new DataGridView();
        Dictionary<string, Report> dicReport = new Dictionary<string, Report>();

        public fReport()
        {
            InitializeComponent();
            cmbThang.SelectedIndex = DateTime.Now.Month - 1;
            numericNam.Value = DateTime.Now.Year;
            getReport();
        }

        void getReport()
        {
            dynamic roomType = roomTypeController.getAll();
            dynamic bill = billController.getAllWithTime(cmbThang.SelectedIndex + 1, (int)numericNam.Value);
            if (bill.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thống kê cho thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (dynamic item in roomType)
            {
                dicReport[item.Name] = new Report(item.Name);
            }

            decimal TongDoanhThu = 0;

            foreach (dynamic item in bill)
            {
                Report re = dicReport[item.RoomType];
                re.revenue += item.Amount;
                dicReport[item.RoomType] = re;

                TongDoanhThu += item.Amount;
            }
            var data = from c in dicReport
                       select new
                       {
                           TenLoaiPhong = c.Value.roomName,
                           DoanhThu = c.Value.revenue,
                           TiLe = Math.Round((c.Value.revenue / TongDoanhThu) * 100, 2)
                       };
            dgvReport.DataSource = data.ToList();

            //List<Report> report = new List<Report>(dicReport.Values.ToList());

            SeriesCollection collection = new SeriesCollection();

            foreach (dynamic item in data.ToList())
            {
                PieSeries pie = new PieSeries();
                pie.Values = new ChartValues<ObservableValue> { new ObservableValue((double)(item.TiLe)) };
                pie.Title = item.TenLoaiPhong;

                collection.Add(pie);
            }

            //PieSeries pie1 = new PieSeries();
            //pie1.Values = new ChartValues<ObservableValue> { new ObservableValue( 0.2) };
            //pie1.Title = "a";

            ////chartReport.Series.Add(pie);

            //PieSeries pie2 = new PieSeries();
            //pie2.Values = new ChartValues<ObservableValue> { new ObservableValue(200) };
            //pie2.Title = "b";
            //pie2.Fill = System.Windows.Media.Brushes.Red;
            //collection.Add(pie1);
            //collection.Add(pie2);

            chartReport.Series = collection;
            lbTittle.Text = "Báo cáo doanh thu tháng " + (cmbThang.SelectedIndex + 1) + " năm " + numericNam.Value;
            //chartReport.

            //chartReport.
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            getReport();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    class Report
    {
        public string roomName;
        public double percent;
        public decimal revenue;

        public Report(string roomName)
        {
            this.roomName = roomName;
        }

        public Report(string roomName, float percent, decimal revenue)
        {
            this.roomName = roomName;
            this.percent = percent;
            this.revenue = revenue;
        }
    }
}
