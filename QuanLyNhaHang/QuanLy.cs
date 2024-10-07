using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace QuanLyNhaHang
{
    public partial class QuanLy : Form
    {
        public event EventHandler Tick;


        public QuanLy()
        {
            
            InitializeComponent();
            handleBackGround();
          
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void handleBackGround()
        {
            Image myimage = new Bitmap(@"C:\Users\hiamchubbybear\source\repos\QuanLyNhaHang\QuanLyNhaHang\milky-way-starry-sky-night-sky-star-956981.jpeg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyMonAn quanLyMonAn = new QuanLyMonAn();
            quanLyMonAn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien nhanVien = new QuanLyNhanVien();
            nhanVien.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.Show();
            this.Hide();

        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.Show();
            this.Hide();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd:MM:yyyy";
            System.Windows.Forms.Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            dateTime.Value = DateTime.Now;

        }
    }
}
