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
    public partial class mian : Form
    {
        public mian()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FKhachhang form = new FKhachhang();
            form.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSanpham form = new FSanpham();
            form.Show();

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHoadon form = new FHoadon();
            form.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitiethoadon form = new Chitiethoadon();
            form.Show();
        }
    }
}
