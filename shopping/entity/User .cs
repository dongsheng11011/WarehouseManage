using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping.entity
{
    internal class User
    {
        private static User _instance;

        private User() { }
        public static User Instance {
            get {
                if (_instance == null) { 
                    _instance = new User();
                }
                return _instance;
            }
        }
        public int Id { get; set; } // 用户唯一标识符，不可修改，自动递增
        public string Username { get; set; } // 用户名，不允许为空，唯一，可修改
        public string Identity { get; set; }
        public string PasswordHash { get; set; } // 存储密码的哈希值，不允许为空
        public DateTime CreatedAt { get; set; } // 记录用户创建的时间
        public DateTime UpdatedAt { get; set; } // 记录用户信息最后更新的时间
    }
}
