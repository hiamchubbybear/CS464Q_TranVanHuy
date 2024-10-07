namespace QuanLyNhaHang
{
    partial class QuanLyMonAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtTen = new TextBox();
            txtXuatXu = new TextBox();
            txtGia = new TextBox();
            txtMoTa = new TextBox();
            lbl = new Label();
            ád = new Label();
            d = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            btnDem = new Button();
            txtDem = new TextBox();
            menuStrip1 = new MenuStrip();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mónĂnToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 219);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(168, 48);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(100, 23);
            txtTen.TabIndex = 2;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(425, 95);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(121, 23);
            txtXuatXu.TabIndex = 3;
            txtXuatXu.TextChanged += textBox2_TextChanged;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(168, 147);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(100, 23);
            txtGia.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(168, 94);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(100, 23);
            txtMoTa.TabIndex = 6;
            // 
            // lbl
            // 
            lbl.Font = new Font("Segoe UI", 10F);
            lbl.Location = new Point(23, 51);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 23);
            lbl.TabIndex = 7;
            lbl.Text = "Mã món ăn";
            // 
            // ád
            // 
            ád.Font = new Font("Segoe UI", 10F);
            ád.Location = new Point(23, 94);
            ád.Name = "ád";
            ád.Size = new Size(100, 23);
            ád.TabIndex = 8;
            ád.Text = "Mô tả";
            // 
            // d
            // 
            d.Font = new Font("Segoe UI", 10F);
            d.Location = new Point(23, 147);
            d.Name = "d";
            d.Size = new Size(100, 23);
            d.TabIndex = 9;
            d.Text = "Giá tiền";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(295, 51);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            label4.Text = "Loại";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(295, 95);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 11;
            label5.Text = "Xuất xứ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(425, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(488, 145);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 23);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(649, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 23);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(338, 145);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 23);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(649, 193);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 16;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDem
            // 
            btnDem.Location = new Point(628, 51);
            btnDem.Name = "btnDem";
            btnDem.Size = new Size(121, 23);
            btnDem.TabIndex = 17;
            btnDem.Text = "Đếm";
            btnDem.UseVisualStyleBackColor = true;
            btnDem.Click += btnDem_Click;
            // 
            // txtDem
            // 
            txtDem.Location = new Point(628, 93);
            txtDem.Name = "txtDem";
            txtDem.Size = new Size(121, 23);
            txtDem.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(77, 20);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(128, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(128, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mónĂnToolStripMenuItem, nhânViênToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click_1;
            // 
            // mónĂnToolStripMenuItem
            // 
            mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            mónĂnToolStripMenuItem.Size = new Size(128, 22);
            mónĂnToolStripMenuItem.Text = "Món ăn";
            mónĂnToolStripMenuItem.Click += mónĂnToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(128, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click_1;
            // 
            // QuanLyMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDem);
            Controls.Add(btnDem);
            Controls.Add(button1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(d);
            Controls.Add(ád);
            Controls.Add(lbl);
            Controls.Add(txtMoTa);
            Controls.Add(txtGia);
            Controls.Add(txtXuatXu);
            Controls.Add(txtTen);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QuanLyMonAn";
            Text = "QuanLyMonAn";
            Load += QuanLyMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private TextBox txtTen;
        private TextBox txtXuatXu;
        private TextBox txtGia;
        private TextBox txtMoTa;
        private Label lbl;
        private Label ád;
        private Label d;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private Button btnDem;
        private TextBox txtDem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mónĂnToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}