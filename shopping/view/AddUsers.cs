using shopping.dao;
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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDao userdao = UserDao.Instance;
            if (userdao.IsUsernameExists(txtUser.Text)) {
                MessageBox.Show("用户名已存在");
                return;
            }
            if (txtPwd.Text == txtPwd2.Text)
            {
                userdao.AddUser(txtUser.Text, txtPwd.Text);
                MessageBox.Show("添加成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("两次输入的密码不同！请重新输入！");
            }
        }
    }
}
