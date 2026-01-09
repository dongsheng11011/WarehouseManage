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

namespace shopping.view
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserDao userdao = UserDao.Instance;
            if (userdao.IsUsernameExists(txtUser.Text))
            {
                if (!userdao.IdentifyingUser(txtUser.Text))
                {
                    userdao.DeleteUser(txtUser.Text);
                    MessageBox.Show("删除成功");
                    return;
                }
                else
                {
                    MessageBox.Show("管理员不可被删除");
                }
            }
            else
            {
                MessageBox.Show("用户不存在");
            }
        }
    }
}
