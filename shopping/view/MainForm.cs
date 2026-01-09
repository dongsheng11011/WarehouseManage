using shopping.dao;
using shopping.entity;
using shopping.view;
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
    public partial class MainForm : Form
    {
        User user = User.Instance;
        public MainForm()
        {
            InitializeComponent();
            string s = this.Text + "   当前用户: " + user.Username + "   身份: " + user.Identity;
            this.Text = s;
        }

        private void GoodsMananger_Click(object sender, EventArgs e)
        {
            GoodsManagerForm form = GoodsManagerForm.Instance;
            form.MdiParent = this;
            form.WindowState = form.WindowState;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void 统计商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticalGoods form = StatisticalGoods.Instance;
            form.MdiParent = this;
            form.WindowState = form.WindowState;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }


        private void 商品种类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeManager form = TypeManager.Instance;
            DialogResult result = form.ShowDialog();  // 显示子窗体并等待用户输入
        }

        private void 过期商品统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpiredGoods form = ExpiredGoods.Instance;
            form.MdiParent = this;
            form.WindowState = form.WindowState;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDao userdao = UserDao.Instance;
            if (!userdao.IdentifyingUser(user.Username))
            {
                MessageBox.Show("当前用户非管理员，不可使用！");
                return;
            }
            AddUsers form = new AddUsers();
            DialogResult result = form.ShowDialog();  // 显示子窗体并等待用户输入
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDao userdao = UserDao.Instance;
            if (!userdao.IdentifyingUser(user.Username))
            {
                MessageBox.Show("当前用户非管理员，不可使用！");
                return;
            }
            DeleteUser form = new DeleteUser();
            DialogResult result = form.ShowDialog();  // 显示子窗体并等待用户输入
        }
    }
}
