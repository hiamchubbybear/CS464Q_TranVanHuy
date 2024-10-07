using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    internal class ProcessHandle
    {
        public String duongDan = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hiamchubbybear\\source\\repos\\QuanLyNhaHang\\QuanLyNhaHang\\QuanLySinhVien.mdf;Integrated Security=True";
        //public SqlConnection  LopChung()
        //{
        //    conn = new SqlConnection(duongDan);
        //    return conn;
        //}

        public ProcessHandle()
        {
        }

        public DataTable LoadDuLieu(String sql)
        {
            SqlConnection conn = new SqlConnection(duongDan);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(String sqlN)
        {
            SqlConnection conn = new SqlConnection(duongDan);

            SqlCommand comm = new SqlCommand(sqlN, conn);
            conn.Open();
            int ketQua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketQua >= 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Không thành công");

            }
        }
        public int Scalar(string sqlS)
        {
            int ketQua = 0; 
            try
            {
                using (SqlConnection conn = new SqlConnection(duongDan))
                {
                    using (SqlCommand comm = new SqlCommand(sqlS, conn))
                    {
                        conn.Open();

                        int result = (int)comm.ExecuteScalar();
                      
                            ketQua = Convert.ToInt32(result);

                    }
                }
            }
            catch (Exception ex)
            {
         
                MessageBox.Show($"Error: {ex.Message}");
            }

            return ketQua;
        }

    }
}
