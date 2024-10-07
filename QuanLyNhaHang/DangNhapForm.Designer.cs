namespace QuanLyNhaHang
{
    partial class DangNhapForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDN = new TextBox();
            txtMK = new TextBox();
            ckbXMK = new CheckBox();
            btnDN = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(54, 129);
            label1.Name = "label1";
            label1.Size = new Size(201, 33);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(54, 245);
            label2.Name = "label2";
            label2.Size = new Size(201, 36);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(274, 53);
            label3.Name = "label3";
            label3.Size = new Size(283, 36);
            label3.TabIndex = 2;
            label3.Text = "Ứng dụng quản lý nhà hàng";
            // 
            // txtDN
            // 
            txtDN.Font = new Font("Segoe UI", 16F);
            txtDN.Location = new Point(354, 129);
            txtDN.Name = "txtDN";
            txtDN.Size = new Size(365, 36);
            txtDN.TabIndex = 3;
            txtDN.TextChanged += txtDN_TextChanged;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 16F);
            txtMK.Location = new Point(354, 245);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(365, 36);
            txtMK.TabIndex = 4;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // ckbXMK
            // 
            ckbXMK.AutoSize = true;
            ckbXMK.Location = new Point(509, 296);
            ckbXMK.Name = "ckbXMK";
            ckbXMK.Size = new Size(103, 19);
            ckbXMK.TabIndex = 5;
            ckbXMK.Text = "Xem mật khẩu";
            ckbXMK.UseVisualStyleBackColor = true;
            ckbXMK.CheckedChanged += ckbXMK_CheckedChanged;
            // 
            // btnDN
            // 
            btnDN.Font = new Font("Segoe UI", 16F);
            btnDN.Location = new Point(118, 338);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(161, 54);
            btnDN.TabIndex = 6;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = true;
            btnDN.Click += button1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 16F);
            btnThoat.Location = new Point(509, 338);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(161, 54);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDN);
            Controls.Add(ckbXMK);
            Controls.Add(txtMK);
            Controls.Add(txtDN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhapForm";
            Text = "Đăng nhập";
            FormClosing += DangNhapForm_FormClosing;
            Load += DangNhapForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDN;
        private TextBox txtMK;
        private CheckBox ckbXMK;
        private Button btnDN;
        private Button btnThoat;
    }
}
