using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using shopping.dao;
using shopping.entity;
using shopping.view;

namespace SupermarketGoodsManangerSystem
{
    public partial class GoodsManagerForm : Form
    {
        //第二种填充表的类型 private DataTable dataTable;
        private BindingList<Product> product;
        public GoodsManagerForm()
        {
            InitializeComponent();
            ProductDao productDao = ProductDao.Instance;
            product = productDao.GetAllProducts();
            // 将 DataTable 绑定到 DataGridView
            viewProduct.DataSource = product; 
            //  关闭窗口隐藏。
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private static GoodsManagerForm _instance;
        public static GoodsManagerForm Instance {
            get
            {
                if (_instance == null) { 
                    _instance = new GoodsManagerForm();
                }
                return _instance;
            }
        }
        private void GoodsManagerForm_Load(object sender, EventArgs e)
        {
            viewProduct.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            // 获取列名（DataPropertyName）
            string sortProperty = viewProduct.Columns[columnIndex].DataPropertyName;

            // 对指定属性进行排序
            SortBindingList(sortProperty);
        }

        //  关闭窗口隐藏。
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 取消关闭操作
            e.Cancel = true;

            // 隐藏窗体而不是关闭
            this.Hide();
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

        //添加商品
        private void button1_Click(object sender, EventArgs e)
        {
            AddGoods form = new AddGoods();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除选中商品", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductDao productDao = ProductDao.Instance;
                // 检查是否有选中的行
                if (viewProduct.SelectedRows.Count > 0)
                {
                    // 遍历所有选中的行
                    foreach (DataGridViewRow row in viewProduct.SelectedRows)
                    {
                        // 确保不是新行
                        if (!row.IsNewRow)
                        {
                            // 获取选中行的对象（假设绑定的对象是Product）
                            Product productToDelete = row.DataBoundItem as Product;
                            // 获取选中行第一列的值，这里假设是ProductId
                            object firstColumnValue = row.Cells[0].Value;  // 第一列存储ProductId或其他标识符

                            // 调用productDao.DeleteProduct方法，并传递第一列的值作为删除标识符
                            if (firstColumnValue != null)
                            {
                                productDao.DeleteProduct(firstColumnValue.ToString());  // 假设DeleteProduct方法接受字符串类型的参数
                            }
                            // 删除BindingList中的对象
                            product.Remove(productToDelete);
                            MessageBox.Show("删除成功！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先选择要删除的行！");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//刷新
        {
            ProductDao productDao = ProductDao.Instance;
            product = productDao.GetAllProducts();
            // 将 DataTable 绑定到 DataGridView
            viewProduct.DataSource = product;
        }

        private void viewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModify_Click_1(object sender, EventArgs e)//修改价格
        {
            // 判断是否有选中的行
            if (viewProduct.SelectedRows.Count > 0)
            {
                // 创建并显示价格输入窗体
                UpdatePrice priceForm = UpdatePrice.Instance;
                DialogResult result = priceForm.ShowDialog();  // 显示子窗体并等待用户输入

                // 如果用户点击了"确定"按钮
                if (result == DialogResult.OK)
                {
                    decimal newPrice = priceForm.NewPrice;  // 获取用户输入的价格

                    // 遍历所有选中的行
                    foreach (DataGridViewRow row in viewProduct.SelectedRows)
                    {
                        // 确保不是新行
                        if (!row.IsNewRow)
                        {
                            // 获取选中行的对象（假设绑定的对象是Product）
                            Product productToModify = row.DataBoundItem as Product;
                            object firstColumnValue = row.Cells[0].Value;
                            if (productToModify != null)
                            {
                                // 更新数据库中的产品信息
                                ProductDao productDao = ProductDao.Instance;
                                productDao.UpdateProduct(firstColumnValue.ToString(),(float)newPrice);
                            }
                        }
                    }
                    MessageBox.Show("价格修改成功！");
                }
            }
            else
            {
                MessageBox.Show("请先选择要修改价格的商品！");
            }
        }
    }
}
