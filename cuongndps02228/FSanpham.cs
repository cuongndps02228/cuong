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
    public partial class FSanpham : Form
    {
        public FSanpham()
        {
            InitializeComponent();
        }

        private void FSanpham_Load(object sender, EventArgs e)
        {

        }
         private bool KT()
        {
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtGia.Text == "" || txtMT.Text == "" )
            {
                MessageBox.Show("chưa nhập đầy đủ dữ liệu", "Thông báo");
                return false;
            }
            return true;
        }
        private void clear()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtGia.Text = "";
            txtMT.Text = "";
           
            
        }
       
        private void btnthem_Click_1(object sender, EventArgs e)
        {
        
        
            bool kt = KT();
            if (kt == true)
            {
                string strQuery = "set dateformat dmy insert into mathang(MaMH, TenMH, Gia, Mota, Maloai) values('" + txtMaMH.Text + "',N'" + txtTenMH.Text + "','" + Convert.ToInt32(txtGia.Text) + "','" + txtMT.Text + "')";
                SQLConnection.executeNonquery(strQuery);

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
        }
            private void Loadsanpham()
            {
    
            }
          

            private void Sanpham_Load_1(object sender, EventArgs e)
            {
                try
                {
                    Loadsanpham();
                  
                }
                catch
                {
                    MessageBox.Show("Chưa có loại sản phẩm");
                }
            }

             private void btnhienthi_Click_1(object sender, EventArgs e)
        {
        
        
                List();
            }
            private void List()
            {
                listView1.Items.Clear();
                DataTable dt = ClsFunction.loadsanpham();
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
                listView1.Items.Add(items);
            }

               private void btnxoa_Click(object sender, EventArgs e)
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
                            string maSP = listView1.Items[index].SubItems[1].Text;
                            string strQuery = "delete from Mathang where MaMH = '" + maSP + "'";
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
                    txtMaMH.Text = listView1.Items[it].SubItems[1].Text;
                    txtTenMH.Text = listView1.Items[it].SubItems[2].Text;

                    txtGia.Text = listView1.Items[it].SubItems[3].Text;
                    txtMT.Text = listView1.Items[it].SubItems[4].Text;
                  


                }
            }

           private void bntsua_Click_1(object sender, EventArgs e)
        {
        
        

                for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                int index = listView1.SelectedIndices[i];
                string strQuery = "set dateformat dmy Update Mathang set TenMH = N'" + txtTenMH.Text + "', Gia = N'" + txtGia.Text + "', Mota = '" + txtMT.Text + "' where MaMH = '" + txtMaMH.Text + "'";
            SQLConnection.executeNonquery(strQuery);

            }
            List();
            clear();
        }

            private void btnnhanlai_Click_1(object sender, EventArgs e)
        {
        
        
                txtMaMH.Text = "";
                txtTenMH.Text = "";

                txtGia.Text = "";
                txtMT.Text = "";
                
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    List();
                }
                else
                {
                    DataTable dt = ClsFunction.TimTheotenSP(textBox1.Text.Trim());
                    listView1.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        Themhienthi(row);
                    }

                }
            }

       

       

     

       

            }

        }
    

 
