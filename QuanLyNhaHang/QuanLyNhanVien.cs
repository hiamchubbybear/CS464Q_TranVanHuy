using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang
{
    public partial class QuanLyNhanVien : Form
    {
        ProcessHandle handleProcess;

        public QuanLyNhanVien()
        {
            InitializeComponent();
            loadNhanVien();
        }
        public String duongDan = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hiamchubbybear\\source\\repos\\QuanLyNhaHang\\QuanLyNhaHang\\QuanLySinhVien.mdf;Integrated Security=True";

        public void loadNhanVien()
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSV = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sqlSV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView12.DataSource = dt;
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView12.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView12.CurrentRow.Cells[1].Value.ToString();
            txtTuoi.Text = dataGridView12.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView12.CurrentRow.Cells[3].Value.ToString();
            txtLuong.Text = dataGridView12.CurrentRow.Cells[4].Value.ToString();
            dtpNgayVaoLam.Text = dataGridView12.CurrentRow.Cells[5].Value.ToString();
            txtHeSoLuong.Text = dataGridView12.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlThem = "INSERT INTO nhanvien (id,ten, tuoi, diachi, luong, ngayvaolam , hesoluong) VALUES" +
                " (@id,@ten, @tuoi, @diachi,@luong, @ngayvaolam , @hesoluong)";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            comm.Parameters.AddWithValue("@id", txtMa.Text);
            comm.Parameters.AddWithValue("@ten", txtTen.Text);
            comm.Parameters.AddWithValue("@tuoi", int.Parse(txtTuoi.Text));
            comm.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            comm.Parameters.AddWithValue("@hesoluong", double.Parse(txtHeSoLuong.Text));
            comm.Parameters.AddWithValue("@luong", double.Parse(txtLuong.Text));
            comm.Parameters.AddWithValue("@ngayvaolam", dtpNgayVaoLam.Value);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Thêm thành công");
                loadNhanVien();
            }
        }

        private void btnDem_Click(object sender, EventArgs e)
        {

            string sql = "SELECT COUNT(*) FROM nhanvien";
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
                txtDem.Text = $"Số nhân viên: {employeeCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlXoa = "delete from monan where id = @id";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.Parameters.AddWithValue("@id", txtMa.Text);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Xoá thành công");
                loadNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //String sqlThem = "INSERT INTO nhanvien (id,ten, tuoi, diachi, luong, ngayvaolam , hesoluong) VALUES" +
            //" (@id,@ten, @tuoi, @diachi,@luong, @ngayvaolam , @hesoluong)";
            SqlConnection conn = new SqlConnection(duongDan);
            String sqlSua = "update nhanvien set ten  =@ten, tuoi = @tuoi, diachi=@diachi, luong =@luong, ngayvaolam=@ngayvaolam, hesoluong= @hesoluong where id=  @id";
            SqlCommand comm = new SqlCommand(sqlSua, conn);
            comm.Parameters.AddWithValue("@id", txtMa.Text);
            comm.Parameters.AddWithValue("@ten", txtTen.Text);
            comm.Parameters.AddWithValue("@tuoi", int.Parse(txtTuoi.Text));
            comm.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            comm.Parameters.AddWithValue("@hesoluong", double.Parse(txtHeSoLuong.Text));
            comm.Parameters.AddWithValue("@luong", double.Parse(txtLuong.Text));
            comm.Parameters.AddWithValue("@ngayvaolam", dtpNgayVaoLam.Value);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Sửa thành công");
                loadNhanVien();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);

            string sql = "SELECT ngayvaolam FROM nhanvien WHERE id = @id";
            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@id", txtMa.Text);
            conn.Open();
            object result = comm.ExecuteScalar(); if (result != null && result != DBNull.Value)
            {

                DateTime ngayVaoLam = Convert.ToDateTime(result);
                TimeSpan ketqua = DateTime.Now - ngayVaoLam;
                MessageBox.Show("Bạn đã vào làm được " + (ketqua.Days.ToString()) + " ngày ", "Ngày làm");
            }
            else
            {
                MessageBox.Show("Không tìm thấy ngày vào làm.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(duongDan);
            string sql = "SELECT hesoluong, luong FROM nhanvien WHERE id = @id"; // Lương cơ bản nên là luongcoban
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", txtMa.Text);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())
                {

                    double hesoluong = reader.GetFloat(0);
                    double luongCoBan = double.Parse(reader.GetString(1));
                    double luong = luongCoBan * hesoluong;
                    MessageBox.Show($"Lương của nhân viên với ID {txtMa.Text} là: {luong.ToString("N0")} đồng.", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với ID này.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
            finally
            {
                conn.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhapForm form = new DangNhapForm();
            form.Show();
            this.Hide();

        }

        private void quảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void mónĂnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyMonAn nhanvien = new QuanLyMonAn();
            nhanvien.Show();
            this.Hide();
        }
    }
}
