namespace QuanLiSinhViennn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radiobtnam = new RadioButton();
            dataGridView1 = new DataGridView();
            btThoat = new Button();
            btSua = new Button();
            btXoa = new Button();
            btThem = new Button();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            textboxMasv = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btLammoi = new Button();
            tbTimkiem = new TextBox();
            lbTimkiem = new Label();
            btTimkiem = new Button();
            textBoxTuoi = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radiobtnam
            // 
            radiobtnam.AutoSize = true;
            radiobtnam.Location = new Point(135, 461);
            radiobtnam.Name = "radiobtnam";
            radiobtnam.Size = new Size(51, 19);
            radiobtnam.TabIndex = 39;
            radiobtnam.TabStop = true;
            radiobtnam.Text = "Nam";
            radiobtnam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(690, 239);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btThoat.Image = (Image)resources.GetObject("btThoat.Image");
            btThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btThoat.Location = new Point(521, 329);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 51);
            btThoat.TabIndex = 34;
            btThoat.Text = "Thoát";
            btThoat.TextAlign = ContentAlignment.MiddleRight;
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btSua
            // 
            btSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btSua.Image = (Image)resources.GetObject("btSua.Image");
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.Location = new Point(526, 440);
            btSua.Name = "btSua";
            btSua.Size = new Size(112, 55);
            btSua.TabIndex = 33;
            btSua.Text = "Sửa";
            btSua.TextAlign = ContentAlignment.MiddleRight;
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btXoa.Image = (Image)resources.GetObject("btXoa.Image");
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.Location = new Point(403, 439);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(112, 56);
            btXoa.TabIndex = 35;
            btXoa.Text = "Xóa";
            btXoa.TextAlign = ContentAlignment.MiddleRight;
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.BackColor = SystemColors.ControlLightLight;
            btThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btThem.Image = (Image)resources.GetObject("btThem.Image");
            btThem.ImageAlign = ContentAlignment.MiddleLeft;
            btThem.Location = new Point(279, 441);
            btThem.Name = "btThem";
            btThem.Size = new Size(112, 55);
            btThem.TabIndex = 36;
            btThem.Text = "Thêm";
            btThem.TextAlign = ContentAlignment.MiddleRight;
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 461);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 20;
            label7.Text = "Giới tính (Nam)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 421);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 22;
            label6.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 421);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 21;
            label3.Text = "Tuổi";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(107, 371);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(137, 23);
            textBoxName.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 371);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 379);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 24;
            label5.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 379);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 23;
            label2.Text = "Tên";
            // 
            // textboxMasv
            // 
            textboxMasv.Location = new Point(107, 328);
            textboxMasv.Name = "textboxMasv";
            textboxMasv.Size = new Size(137, 23);
            textboxMasv.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 336);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 25;
            label4.Text = "Mã";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 328);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 336);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 26;
            label1.Text = "Mã";
            // 
            // btLammoi
            // 
            btLammoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLammoi.Image = (Image)resources.GetObject("btLammoi.Image");
            btLammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btLammoi.Location = new Point(334, 329);
            btLammoi.Name = "btLammoi";
            btLammoi.Size = new Size(128, 50);
            btLammoi.TabIndex = 40;
            btLammoi.Text = "Làm mới";
            btLammoi.TextAlign = ContentAlignment.MiddleRight;
            btLammoi.UseVisualStyleBackColor = true;
            btLammoi.Click += btLamMoi_Click;
            // 
            // tbTimkiem
            // 
            tbTimkiem.Location = new Point(350, 28);
            tbTimkiem.Name = "tbTimkiem";
            tbTimkiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            tbTimkiem.Size = new Size(165, 23);
            tbTimkiem.TabIndex = 41;
            // 
            // lbTimkiem
            // 
            lbTimkiem.AutoSize = true;
            lbTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimkiem.Location = new Point(279, 34);
            lbTimkiem.Name = "lbTimkiem";
            lbTimkiem.Size = new Size(65, 15);
            lbTimkiem.TabIndex = 42;
            lbTimkiem.Text = "Tìm kiếm :";
            // 
            // btTimkiem
            // 
            btTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btTimkiem.Location = new Point(521, 28);
            btTimkiem.Name = "btTimkiem";
            btTimkiem.Size = new Size(75, 23);
            btTimkiem.TabIndex = 43;
            btTimkiem.Text = "Tìm";
            btTimkiem.UseVisualStyleBackColor = true;
            btTimkiem.Click += button1_TimKiem_Click;
            // 
            // textBoxTuoi
            // 
            textBoxTuoi.Location = new Point(107, 413);
            textBoxTuoi.Name = "textBoxTuoi";
            textBoxTuoi.Size = new Size(137, 23);
            textBoxTuoi.TabIndex = 29;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "mssv";
            Column1.HeaderText = "Mã Sinh Viên";
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Tên Sinh Viên";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ngaysinh";
            Column3.HeaderText = "Ngày Sinh";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.DataPropertyName = "gioitinh";
            Column4.HeaderText = "Giới Tính(Nam)";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 113;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "hinhanh";
            Column5.HeaderText = "Hinh anh";
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(707, 507);
            Controls.Add(btTimkiem);
            Controls.Add(lbTimkiem);
            Controls.Add(tbTimkiem);
            Controls.Add(btLammoi);
            Controls.Add(radiobtnam);
            Controls.Add(dataGridView1);
            Controls.Add(btThoat);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBoxTuoi);
            Controls.Add(textBoxName);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textboxMasv);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radiobtnam;
        private DataGridView dataGridView1;
        private Button btThoat;
        private Button btSua;
        private Button btXoa;
        private Button btThem;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBox2;
        private Label label5;
        private Label label2;
        private TextBox textboxMasv;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private Button btLammoi;
        private TextBox tbTimkiem;
        private Label lbTimkiem;
        private Button btTimkiem;
        private TextBox textBoxTuoi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewImageColumn Column5;
    }
}