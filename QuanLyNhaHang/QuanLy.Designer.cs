namespace QuanLyNhaHang
{
    partial class QuanLy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            dateTime = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTime
            // 
            dateTime.CalendarFont = new Font("Segoe UI", 16F);
            dateTime.CalendarForeColor = Color.Cornsilk;
            dateTime.Font = new Font("Segoe UI", 11F);
            dateTime.Format = DateTimePickerFormat.Time;
            dateTime.Location = new Point(683, 423);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(117, 27);
            dateTime.TabIndex = 10;
            dateTime.TabStop = false;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(437, 89);
            button2.Name = "button2";
            button2.Size = new Size(208, 49);
            button2.TabIndex = 12;
            button2.Text = "Quản lý món ăn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(437, 194);
            button1.Name = "button1";
            button1.Size = new Size(208, 49);
            button1.TabIndex = 13;
            button1.Text = "Quản lý nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(437, 309);
            button3.Name = "button3";
            button3.Size = new Size(208, 49);
            button3.TabIndex = 14;
            button3.Text = "Trở lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(356, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(444, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dateTime);
            MainMenuStrip = menuStrip1;
            Name = "QuanLy";
            Text = "QuanLy";
            FormClosing += QuanLy_FormClosing;
            Load += QuanLy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTime;
        private Button button2;
        private Button button1;
        private Button button3;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
    }
}