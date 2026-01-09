using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketGoodsManangerSystem
{
    public partial class InquireGoods : Form
    {
        public string ProductName = null;
        public InquireGoods()
        {
            InitializeComponent();
        }
        private void btn_Inquire_Click(object sender, EventArgs e)
        {
            ProductName = txtProductName.Text;
            DialogResult = DialogResult.OK;
                // 用户点击了“确定”按钮
            this.Close();
        }
    }
}
