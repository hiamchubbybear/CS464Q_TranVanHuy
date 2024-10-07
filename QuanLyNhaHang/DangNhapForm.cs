using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang
{
    public partial class DangNhapForm : Form
    {
        int tat = 0;


        public DangNhapForm()
        {
            handleBackGround();
            InitializeComponent();
            if (btnDN.CanFocus)
            {
                btnDN.Focus();
            }
            txtDN.Text = "admin";
            txtDN.DeselectAll();
            txtMK.Text = "123456";
            txtMK.DeselectAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDN_TextChanged(object sender, EventArgs e)
        {

        }
        int dem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            String tenDN = txtDN.Text;
            String matKhau = txtMK.Text;
            if (tenDN == "admin" && matKhau == "123456")
            {
                QuanLy quanLy = new QuanLy();

                quanLy.Show();
                dem = 1;
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Sai đăng nhập hoặc mật khẩu " + dem);
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã sai 3 lần liên tiếp, Exit");
                    Application.Exit();
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tat = 1;
                Application.Exit();
            }
        }

        private void ckbXMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void handleBackGround()
        {
            Image myimage = new Bitmap(@"C:\Users\hiamchubbybear\source\repos\QuanLyNhaHang\QuanLyNhaHang\milky-way-starry-sky-night-sky-star-956981.jpeg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DangNhapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnDN;

        }
    }
}
