namespace cuongndps02228
{
    partial class FSanpham
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnnhanlai = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.bntsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên loại";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mô tả";
            this.columnHeader6.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên hàng";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã MH";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "STT";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(41, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 200);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // btnnhanlai
            // 
            this.btnnhanlai.Location = new System.Drawing.Point(519, 19);
            this.btnnhanlai.Name = "btnnhanlai";
            this.btnnhanlai.Size = new System.Drawing.Size(75, 23);
            this.btnnhanlai.TabIndex = 3;
            this.btnnhanlai.Text = "Nhập lại";
            this.btnnhanlai.UseVisualStyleBackColor = true;
            this.btnnhanlai.Click += new System.EventHandler(this.btnnhanlai_Click_1);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(394, 19);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(75, 23);
            this.btnhienthi.TabIndex = 3;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(144, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(269, 19);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(75, 23);
            this.bntsua.TabIndex = 3;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            this.bntsua.Click += new System.EventHandler(this.bntsua_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnhanlai);
            this.groupBox2.Controls.Add(this.btnhienthi);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.bntsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(41, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 53);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(19, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(407, 13);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(151, 20);
            this.txtGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(97, 50);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(151, 20);
            this.txtTenMH.TabIndex = 1;
            // 
            // txtMT
            // 
            this.txtMT.Location = new System.Drawing.Point(407, 50);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(151, 20);
            this.txtMT.TabIndex = 1;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(97, 16);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(151, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(41, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 53);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtMT);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Location = new System.Drawing.Point(41, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 127);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // FSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 445);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FSanpham";
            this.Text = "FSanpham";
            this.Load += new System.EventHandler(this.FSanpham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnnhanlai;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMT;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}