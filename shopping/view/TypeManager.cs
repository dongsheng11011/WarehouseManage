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

namespace shopping.view
{
    public partial class TypeManager : Form
    {
        private BindingList<ProductType> Type;
        public TypeManager()
        {
            InitializeComponent();
            ProductDao productDao = ProductDao.Instance;
            Type = productDao.GetALLType();
            // 将 DataTable 绑定到 DataGridView
            viewType.DataSource = Type;
            //  关闭窗口隐藏。
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private static TypeManager _instance;
        public static TypeManager Instance {
            get {
                if (_instance == null) { 
                    _instance = new TypeManager();
                }   
                return _instance; 
            }
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
            string TypeName = txtQuery.Text;
            ProductDao productDao = ProductDao.Instance;
            Type = productDao.GetALLTypeByName(TypeName);
            // 将 DataTable 绑定到 DataGridView
            viewType.DataSource = Type;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string TypeName = txtAdd.Text;
            if (TypeName == null || TypeName.Length <= 0)
            {
                MessageBox.Show("名称不能为空");
                return;
            }
            ProductDao productDao = ProductDao.Instance;
            if (productDao.AddProductType(TypeName))
            {
                MessageBox.Show("添加成功");
                // 重新获取。
                Type = productDao.GetALLType();
                // 将 DataTable 绑定到 DataGridView
                viewType.DataSource = Type;
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            //调了参数
            // this.viewType.MultiSelect = false;

            string TypeName = txtDel.Text;
            if (labId.Text == null) {
                return;
            }
            int TypeID = Convert.ToInt32(labId.Text);
            ProductDao productDao = ProductDao.Instance;
            if (productDao.DeleteProductType(TypeID))
            {
                MessageBox.Show("删除成功");
                // 删除成功重新获取列表数据。
                Type = productDao.GetALLTypeByName(txtQuery.Text);
                // 将 DataTable 绑定到 DataGridView
                viewType.DataSource = Type;
            }
        }

        private void viewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 检查是否有行被选中
            if (e.RowIndex >= 0)
            {
                // 选中的行
                DataGridViewRow row = this.viewType.Rows[e.RowIndex];
                string typeID = row.Cells["typeIDDataGridViewTextBoxColumn"].Value.ToString();
                string typeName = row.Cells["typeNameDataGridViewTextBoxColumn"].Value.ToString();
                labId.Text = typeID;
                labType.Text = "种类:" + typeName;
                txtDel.Text = typeName;
            }
            else
            {
                labId.Text = "";
                labType.Text = "种类:";
            }
        }
    }
}
