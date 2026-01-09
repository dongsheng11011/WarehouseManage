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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SupermarketGoodsManangerSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDao userdao = UserDao.Instance;
            bool loginFlag = false;
            string userName = txtUserName.Text;
            string password = txtUserpwd.Text;

            //userdao.AddUser(userName, password);
            bool flag = userdao.IsUsernameExists(userName);
            if (flag)
            {
                int userID = (int)userdao.GetUserIdByUsername(userName);
                if (userID >= 0)
                {
                    bool flag2 = userdao.VerifyPassword(userID, password);
                    if (flag2)
                    {
                        MessageBox.Show("登录成功！");
                        loginFlag = true;
                        User user = User.Instance;
                        user.Username = userName;
                        if(userdao.IdentifyingUser(userName))
                        {
                            user.Identity = "管理员";
                        }
                        else
                        {
                            user.Identity = "普通用户";
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
            }
            else
            {
                MessageBox.Show("用户名不存在！");
            }
            if (loginFlag)
            {
                MainForm form = new MainForm();
                this.Hide();
                form.Show();
            }
        }
    }
}
