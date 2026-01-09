using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping.view
{
    public partial class UpdatePrice : Form
    {
        public decimal NewPrice { get; private set; }  // 用于返回用户输入的价格
        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatePrice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 尝试将文本框中的输入转换为 decimal
            if (decimal.TryParse(textPrice.Text, out decimal price))
            {
                NewPrice = price;  // 将输入的价格保存到 NewPrice 属性
                DialogResult = DialogResult.OK;  // 设置窗体的返回值为 OK，表示用户确认
                Close();  // 关闭窗体
            }
            else
            {
                MessageBox.Show("请输入有效的价格！", "输入无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
