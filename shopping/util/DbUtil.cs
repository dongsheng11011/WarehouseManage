using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using shopping.entity;

namespace shopping.util
{
    internal class DbUtil
    {
        // 数据库连接字符串
        private readonly String connectionString = "server=localhost;user=root;database=shopping;port=3306;password=123456";
        private static DbUtil _instance;
        public MySqlConnection conn;
        private DbUtil() { }

        public static DbUtil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbUtil();
                }
                return _instance;
            }
        }
        public void GetCon()
        {
           this.conn = new MySqlConnection(connectionString);
           conn.Open();
        }

        public void CloseCon() {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
