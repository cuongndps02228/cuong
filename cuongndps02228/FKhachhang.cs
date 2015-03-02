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
    public partial class FKhachhang : Form
    {
        public FKhachhang()
        {
            InitializeComponent();
        }

       
        private void clear()
        {
            txtMaKh.Text = "";
            txtTenKH.Text = "";

            txtDiachi.Text = "";
            txtDienthoai.Text = "";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        
            bool kt = KT();
            if (kt == true)
            {
                ClsFunction.themkhachhang(txtMaKh.Text, txtTenKH.Text, txtDiachi.Text, txtDienthoai.Text);

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
        }
        private bool KT()
        {
            if (txtMaKh.Text == "" || txtTenKH.Text == "" || txtDiachi.Text == "" || txtDienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }
            return true;
        }

      
        private void button3_Click_1(object sender, EventArgs e)
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
                        string makh = listView1.Items[index].SubItems[1].Text;
                        ClsFunction.xoakh(makh);
                    }
                    List();
                    clear();
                }

            }
        }
        private void List()
        {
            listView1.Items.Clear();
            DataTable dt = ClsFunction.loadkhachhang();
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


            listView1.Items.Add(items);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        

            List();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        

            if (listView1.SelectedIndices.Count == 1)
            {
                int it = listView1.SelectedIndices[0];
                txtMaKh.Text = listView1.Items[it].SubItems[1].Text;
                txtTenKH.Text = listView1.Items[it].SubItems[2].Text;

                txtDiachi.Text = listView1.Items[it].SubItems[3].Text;
                txtDienthoai.Text = listView1.Items[it].SubItems[4].Text;


            }
        }

    
        private void button5_Click_1(object sender, EventArgs e)
        {

        
            txtMaKh.Text = "";
            txtTenKH.Text = "";

            txtDiachi.Text = "";
            txtDienthoai.Text = "";
        }

            private void button2_Click_1(object sender, EventArgs e)
        {

        
            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                int index = listView1.SelectedIndices[i];
                ClsFunction.suakh(txtMaKh.Text, txtTenKH.Text, txtDiachi.Text, txtDienthoai.Text);

            }
            List();
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                List();
            }
            else
            {
                DataTable dt = ClsFunction.TimTheotenkh(textBox1.Text.Trim());
                listView1.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Themhienthi(row);
                }

            }
        }

        private void FKhachhang_Load(object sender, EventArgs e)
        {

        }

       
   

     

      
    }


}

