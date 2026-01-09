using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopping.dao;
using shopping.entity;
using SupermarketGoodsManangerSystem;

namespace shopping.view
{
    public partial class ExpiredGoods : Form
    {
        //第二种填充表的类型 private DataTable dataTable;
        private BindingList<Product> product;
        public ExpiredGoods()
        {
            InitializeComponent();
            ProductDao productDao = ProductDao.Instance;
            product = productDao.GetExpireProducts();
            // 绑定到 DataGridView
            ExpireGridView.DataSource = product;
            //  关闭窗口隐藏。
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private static ExpiredGoods _instance;
        public static ExpiredGoods Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExpiredGoods();
                }
                return _instance;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 取消关闭操作
            e.Cancel = true;
            // 隐藏窗体而不是关闭
            this.Hide();
        }
        private void ExpireGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 选中的行
                DataGridViewRow row = this.ExpireGridView.Rows[e.RowIndex];
                string day = row.Cells["过期天数"].Value.ToString();
                string productName = row.Cells["商品名称"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["售价"].Value); // 获取售价
                int stock = Convert.ToInt32(row.Cells["库存"].Value); // 获取库存
                // 计算总价值
                decimal allPrice = price * stock;

                labDay.Text = "过期天数:" + day;
                labProductName.Text = "商品名称:" + productName;
                labAllPrice.Text = "总价值：" + allPrice;


            }
            else {
                labDay.Text = "过期天数:";
                labProductName.Text = "商品名称:";
                labAllPrice.Text = "总价值：";
            }
        }

        private void ExpiredGoods_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
