using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class QuanLyMonAn : Form
    {
        public QuanLyMonAn()
        {

            InitializeComponent();
            loadCB(); handleBackGround();
            loadMonAn();
        }
        ProcessHandle processHandle = new ProcessHandle();
        public String duongDan = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hiamchubbybear\\source\\repos\\QuanLyNhaHang\\QuanLyNhaHang\\QuanLySinhVien.mdf;Integrated Security=True";
        public void loadMonAn()
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from monan";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void QuanLyMonAn_Load(object sender, EventArgs e)
        {

        }
        public void handleBackGround()
        {
            Image myimage = new Bitmap(@"C:\Users\hiamchubbybear\source\repos\QuanLyNhaHang\QuanLyNhaHang\milky-way-starry-sky-night-sky-star-956981.jpeg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void loadCB( )
        {

            String sqlKhoa = "select * from loai";
            SqlConnection conn = new SqlConnection(duongDan);

            SqlDataAdapter da = new SqlDataAdapter(sqlKhoa, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "loai";
            comboBox1.ValueMember = "id";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlThem = "INSERT INTO monan (ten, mota, giatien, loai, xuatxu) VALUES (@ten, @mota, @giatien, @loai, @xuatxu)";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            comm.Parameters.AddWithValue("@ten", txtTen.Text);
            comm.Parameters.AddWithValue("@mota", txtMoTa.Text);
            if (int.TryParse(txtGia.Text, out int gia))
            {
                comm.Parameters.AddWithValue("@giatien", gia);
            }
            else
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.");
                return;
            }
            comm.Parameters.AddWithValue("@loai", comboBox1.Text);
            comm.Parameters.AddWithValue("@xuatxu", txtXuatXu.Text);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Thêm thành công");
                loadMonAn();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlXoa = "delete from monan where ten = @ten";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.Parameters.AddWithValue("@ten", txtTen.Text);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Xoá thành công");
                loadMonAn();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMoTa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtXuatXu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSua = "update monan set  mota = @mota , giatien = @giatien, loai = @loai, xuatxu = @xuatxu where ten =  @ten";
            SqlCommand comm = new SqlCommand(sqlSua, conn);
            comm.Parameters.AddWithValue("@ten", txtTen.Text);
            comm.Parameters.AddWithValue("@mota", txtMoTa.Text);
            comm.Parameters.AddWithValue("@giatien", int.Parse(txtGia.Text));
            comm.Parameters.AddWithValue("@loai", comboBox1.Text);
            comm.Parameters.AddWithValue("@xuatxu", txtXuatXu.Text);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Sửa thành công");
                loadMonAn();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.Show();
            this.Hide();
        }

        private void btnDem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM monan";
            int employeeCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(duongDan))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        employeeCount = (int)command.ExecuteScalar();
                    }
                }
                txtDem.Text = $"Số món ăn: {employeeCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy quanly = new QuanLy();
            quanly.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhapForm form = new DangNhapForm();
            form.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyNhanVien nhanvien = new QuanLyNhanVien();
            nhanvien.Show();
            this.Hide();

        }

        private void quảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
