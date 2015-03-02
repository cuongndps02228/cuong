using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuongndps02228
{
    public partial class FHoadon : Form
    {
        public FHoadon()
        {
            InitializeComponent();
        }
          private bool KT()
        {
            if (txtMaHD.Text == "" || dtpngay.Text == "" || txttenkhachhang.Text == "" || txttongtien.Text == "" || cbbKH.Text == "")
            {
                MessageBox.Show("chưa nhập đầy đủ dữ liệu", "Thông báo");
                return false;
            }
            return true;
        }
        private void clear()
        {
            txtMaHD.Text = "";
            dtpngay.Text = "";
            txttenkhachhang.Text = "";
            txttongtien.Text = "";

        }
           private void btnthem_Click_1(object sender, EventArgs e)
        {
        
        
            bool kt = KT();
            if (kt == true)
            {
                string strQuery = "set dateformat dmy insert into Hoadon(MaHD, NgaylapHD, TenKH, Tongtien, MaKH) values('" + txtMaHD.Text + "',N'" + dtpngay.Value + "',N'" + txttenkhachhang.Text + "','" + txttongtien.Text + "',N'" + cbbKH.Text + "')";
                SQLConnection.executeNonquery(strQuery);

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
        }

        private void FHoadon_Load(object sender, EventArgs e)
        {
            try
            {
                loadkhachhang();
                cbbKH.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Chưa có Mã khách hàng");
            }
        }
        private void loadkhachhang()
        {
            DataTable dt = ClsFunction.loadkhachhang();
            cbbKH.DataSource = dt;
            cbbKH.DisplayMember = "MaKH";
            cbbKH.ValueMember = "TenKH";
        }

         private void btnhienthi_Click_1(object sender, EventArgs e)
        {
        
        

            List();
        }
        private void List()
        {
            listView1.Items.Clear();
            DataTable dt = ClsFunction.loadhoadon();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((listView1.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
            items.SubItems.Add(row.ItemArray[3].ToString());
            items.SubItems.Add(row.ItemArray[4].ToString());
            //items.SubItems.Add(row.ItemArray[5].ToString());
            listView1.Items.Add(items);
        }

           private void btnxoa_Click_1(object sender, EventArgs e)
        {

        
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult dialogResuit = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResuit == DialogResult.Yes)
                {
                    int dem = listView1.SelectedIndices.Count;
                    for (int i = dem - 1; i >= 0; i--)
                    {
                        int index = listView1.SelectedIndices[i];
                        string Ma = listView1.Items[index].SubItems[1].Text;
                        string strQuery = "delete from Hoadon where MaHD = '" + txtMaHD.Text + "'";
                        SQLConnection.executeNonquery(strQuery);
                    }
                    List();
                    clear();
                }

            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        

     
            if (listView1.SelectedIndices.Count == 1)
            {
                int it = listView1.SelectedIndices[0];
                txtMaHD.Text = listView1.Items[it].SubItems[1].Text;
                dtpngay.Text = listView1.Items[it].SubItems[2].Text;
                txttenkhachhang.Text = listView1.Items[it].SubItems[3].Text;
                txttongtien.Text = listView1.Items[it].SubItems[4].Text;
                cbbKH.Text = listView1.Items[it].SubItems[5].Text;



            }
        }

           private void bntsua_Click_1(object sender, EventArgs e)
        {

        

            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                int index = listView1.SelectedIndices[i];
                string strQuery = "set dateformat dmy Update Hoadon set NgaylapHD = N'" + dtpngay.Text + "', TenKH = N'" + txttenkhachhang.Text + "', Tongtien = N'" + txttongtien.Text + "', MaKH = '" + cbbKH.Text + "' where MaHD = '" + txtMaHD.Text + "'";
                SQLConnection.executeNonquery(strQuery);
            }
            List();
            clear();
        }

        private void btnnhanlai_Click_1(object sender, EventArgs e)
        {

        

            txtMaHD.Text = "";
            dtpngay.Text = "";
            txttenkhachhang.Text = "";
            txttongtien.Text = "";

        }

       
     
     

      
    
    }
}


        //private void FHoadon_Load(object sender, EventArgs e)
        //{

        //}
    

