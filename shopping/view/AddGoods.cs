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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketGoodsManangerSystem
{
    public partial class AddGoods : Form
    {
        private BindingList<ProductType> product;
        public AddGoods()
        {
            InitializeComponent();
            ProductDao productDao = ProductDao.Instance;
            product = productDao.GetAllType();
            productType.DataSource = product;
            // 将 BindingList 绑定到 ComboBox 的 DataSource 属性
            productType.DataSource = product;
            // 设置显示文本为 TypeName
            productType.DisplayMember = "TypeName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 检查 ComboBox 是否有选中项
            if (productType.SelectedItem == null)
            {
                // 如果没有选中项，弹出提示框并退出方法
                MessageBox.Show("请选择商品类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 退出方法
            }

            // 检查必填的文本框是否为空或空白
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtRetailPrice.Text) ||
                string.IsNullOrWhiteSpace(txtShelfLifeDays.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Value.ToString()))  // 数量的值需要转为字符串来判断
            {
                MessageBox.Show("有属性未填写完！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 退出方法
            }

            // 如果 ComboBox 和文本框都验证通过，则继续执行其他操作
            Product product = new Product();
            string selectedTypeName = ((ProductType)productType.SelectedItem).TypeName;
            product.ProductTypeName = selectedTypeName;
            product.SupplierName = txtSupplierName.Text;     // 厂商
            product.ProductCode = txtProductCode.Text;       // 商品的编号
            product.ProductName = txtProductName.Text;       // 商品的名称
            product.RetailPrice = float.Parse(txtRetailPrice.Text); // 商品的价格
            product.ProductionDate = dateTimePicker1.Value;  // 商品的生产日期
            product.ShelfLifeDays = int.Parse(txtShelfLifeDays.Text);  // 商品的保质期（以天数表示）
            product.ProductNumber = (int)txtNumber.Value;    // 商品的数量

            // 创建 ProductDao 对象并添加商品
            ProductDao productdao = ProductDao.Instance;
            productdao.AddProduct(product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 清空各个文本框的内容
            txtSupplierName.Clear();  // 清空厂商名称
            txtProductCode.Clear();   // 清空商品编号
            txtProductName.Clear();   // 清空商品名称
            txtRetailPrice.Clear();   // 清空商品价格
            txtShelfLifeDays.Clear(); // 清空保质期天数

            // 重置生产日期选择器的值
            dateTimePicker1.Value = DateTime.Now;  // 设置为当前日期

            // 重置商品数量为默认值0
            txtNumber.Value = 0;
            MessageBox.Show("清空完成。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddGoods_Load(object sender, EventArgs e)
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
