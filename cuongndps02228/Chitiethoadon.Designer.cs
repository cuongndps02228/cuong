namespace cuongndps02228
{
    partial class Chitiethoadon
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnhanlai = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.bntsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 214);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 200);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã hóa đơn";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày lập";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên khách hàng";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng tiền";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã khách hàng";
            this.columnHeader6.Width = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnhanlai);
            this.groupBox2.Controls.Add(this.btnhienthi);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.bntsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 53);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnnhanlai
            // 
            this.btnnhanlai.Location = new System.Drawing.Point(519, 19);
            this.btnnhanlai.Name = "btnnhanlai";
            this.btnnhanlai.Size = new System.Drawing.Size(75, 23);
            this.btnnhanlai.TabIndex = 3;
            this.btnnhanlai.Text = "Nhập lại";
            this.btnnhanlai.UseVisualStyleBackColor = true;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(394, 19);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(75, 23);
            this.btnhienthi.TabIndex = 3;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(144, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(269, 19);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(75, 23);
            this.bntsua.TabIndex = 3;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(17, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // Chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 426);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Chitiethoadon";
            this.Text = "Chitiethoadon";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnhanlai;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.Button btnthem;
    }
}