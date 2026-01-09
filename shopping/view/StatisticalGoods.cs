using shopping.dao;
using shopping.entity;
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
    public partial class StatisticalGoods : Form
    {
        private BindingList<Product> product;
        public StatisticalGoods()
        {
            InitializeComponent();
            ProductDao productDao = ProductDao.Instance;
            product = productDao.GetAllProducts();
            // 将 DataTable 绑定到 DataGridView
            viewProduct.DataSource = product;
            StatisticalData(product);
            //  关闭窗口隐藏。
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private static StatisticalGoods _instance;
        public static StatisticalGoods Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StatisticalGoods();
                }
                return _instance;
            }
        }
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending; // 默认升序
        // 自定义排序函数
        private void SortBindingList(string sortProperty)
        {
            // 切换排序方向
            var newSortDirection = currentSortDirection == ListSortDirection.Ascending
                ? ListSortDirection.Descending
                : ListSortDirection.Ascending;

            // 排序
            var sortedList = product.OrderBy(p => p.GetType().GetProperty(sortProperty).GetValue(p, null)).ToList();

            if (newSortDirection == ListSortDirection.Descending)
            {
                sortedList = sortedList.AsEnumerable().Reverse().ToList(); // 降序
            }

            // 使用新的排序结果更新 BindingList
            product.Clear();
            foreach (var item in sortedList)
            {
                product.Add(item);
            }

            // 更新当前排序方向
            currentSortDirection = newSortDirection;
        }
        //  关闭窗口隐藏。
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            // 取消关闭操作
            e.Cancel = true;
            // 隐藏窗体而不是关闭
            this.Hide();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            InquireGoods form = new InquireGoods();
            DialogResult result = form.ShowDialog();  // 显示子窗体并等待用户输入
            if (result == DialogResult.OK)
            {
                ProductDao productDao = ProductDao.Instance;
                // 查询：
                product = productDao.GetProductByName(form.ProductName);
                viewProduct.DataSource = product;
                StatisticalData(product);
            }
        }
        
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            // 获取列名（DataPropertyName）
            string sortProperty = viewProduct.Columns[columnIndex].DataPropertyName;

            // 对指定属性进行排序
            SortBindingList(sortProperty);
        }

        private void StatisticalGoods_Load(object sender, EventArgs e)
        {
            viewProduct.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }

        private void StatisticalData(BindingList<Product> products) {
            if (products == null || products.Count == 0)
            {
                labAvgPrice.Text = "平均价格:";
                labMaxPrice.Text = "最高价格:";
                labMinPrice.Text = "最低价格:";
                labtotalType.Text = "商品种类数:";
                //空列表不做数据处理
                return;
            }

            // 初始化统计变量
            double totalRetailPrice = 0;
            int productCount = products.Count;
            //double maxPrice = ;
            //double minPrice = ;
            double maxPrice = products.Max(p => p.RetailPrice);
            double minPrice = products.Min(p => p.RetailPrice);
            // 使用 HashSet 来存储不同的产品种类
            HashSet<string> productTypes = new HashSet<string>();

            // 遍历产品列表，计算总零售价
            foreach (Product product in products)
            {
                //maxPrice = Math.Max(maxPrice, product.RetailPrice);
                //minPrice = Math.Min(minPrice, product.RetailPrice);
                totalRetailPrice += product.RetailPrice;
                if (!string.IsNullOrEmpty(product.ProductTypeName))
                { // ProductTypeName串非空或者不是null。
                    // 将产品种类添加到 HashSet 中，自动处理重复
                    productTypes.Add(product.ProductTypeName);
                }
            }

            double avgPrice = totalRetailPrice / productCount;

            labAvgPrice.Text = $"平均价格: {avgPrice}";
            labMaxPrice.Text = $"最高价格: {maxPrice}";
            labMinPrice.Text = $"最低价格: {minPrice}";
            //字符串插值。
            labtotalType.Text = $"商品种类数: {productTypes.Count}";
            return;
        }
    }
}
