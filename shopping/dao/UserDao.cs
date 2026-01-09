using MySql.Data.MySqlClient;
using shopping.entity;
using shopping.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace shopping.dao
{
    internal class UserDao
    {
        // 创建工具实例。
        private DbUtil dbUtil = DbUtil.Instance;
        private static UserDao _instance;
        private UserDao() { }

        public static UserDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserDao();
                }
                return _instance;
            }
        }

        //判断用户是否为管理员
        public bool IdentifyingUser(string username)
        {
            try
            {
                // 确保连接已成功打开
                dbUtil.GetCon();
                if (dbUtil.conn.State != System.Data.ConnectionState.Open)
                {
                    throw new InvalidOperationException("数据库连接失败，连接未打开");
                }

                // 执行 SQL 操作
                string query = "SELECT identity FROM users WHERE username = @username;";
                MySqlCommand command = new MySqlCommand(query, dbUtil.conn);
                command.Parameters.AddWithValue("@username", username);

                // 执行查询并读取结果
                var result = command.ExecuteScalar();

                // 检查查询结果是否为 null 或是否为 "管理员"
                if (result != null && result.ToString() == "管理员")
                {
                    return true;  // 如果是管理员，返回 true
                }
                else
                {
                    return false; // 如果不是管理员或没有找到用户，返回 false
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;  // 出现异常时返回 false
            }
            finally
            {
                dbUtil.CloseCon(); // 确保关闭连接
            }
        }

        // 根据用户名删除数据库中的用户
        public void DeleteUser(string userName)
        {
            try
            {
                // 确保连接已成功打开
                dbUtil.GetCon();
                if (dbUtil.conn.State != System.Data.ConnectionState.Open)
                {
                    throw new InvalidOperationException("数据库连接失败，连接未打开");
                }

                // 继续执行 SQL 操作
                string query = "DELETE FROM users WHERE username = @UserName;";
                MySqlCommand command = new MySqlCommand(query, dbUtil.conn);
                command.Parameters.AddWithValue("@UserName", userName);

                // 执行删除操作
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} rows were deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                dbUtil.CloseCon(); // 确保关闭连接
            }
        }

        // 添加用户
        public bool AddUser(string username,string password) {
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    string query = "INSERT INTO users (username, password_hash, identity) VALUES (@Username, @PasswordHash, '普通用户')";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        // 对密码进行哈希处理
                        string hashedPassword = HashPassword(password);
                        // 添加参数并赋值
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        // 执行插入操作
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // 如果受影响的行数大于0，则表示插入成功
                        return rowsAffected > 0;
                    }
                }
            }
            catch (MySqlException mySqlEx)
            {
                // 处理数据库相关的异常
                Console.WriteLine("Database error: " + mySqlEx.Message);
                return false;
            }
            finally
            {
                dbUtil.CloseCon();
            }
        }

        // 密码哈希处理方法
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // 查询用户名是否存在并返回一个bool值
        public bool IsUsernameExists(string userName) {
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 使用ADO.NET或Entity Framework执行数据库插入操作
                    string query = "SELECT COUNT(1) FROM users WHERE username =@userName ";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (MySqlException mySqlEx)
            {
                // 处理数据库相关的异常
                Console.WriteLine("Database error: " + mySqlEx.Message);
                return false;
            }
            finally
            {
                dbUtil.CloseCon();
            }
        }

        // 查询密码是否匹配的方法
        public bool VerifyPassword(int userId, string password)
        {
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 将输入的密码哈希化
                    string inputPasswordHash = HashPassword(password); 
                    string query = "SELECT password_hash FROM users WHERE id=@userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["password_hash"].ToString();
                                string inputHash = HashPassword(password);
                                return storedHash == inputHash; // 比较哈希值是否一致
                            }
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException mySqlEx)
            {
                // 处理数据库相关的异常
                Console.WriteLine("Database error: " + mySqlEx.Message);
                return false;
            }
            finally
            {
                dbUtil.CloseCon();
            }
        }

        // 查询用户名并返回id或null
        public int? GetUserIdByUsername(string username)
        {
            string query = "SELECT id FROM users WHERE username=@username";
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将读取到的用户 ID 转换为 int 类型，如果存在的话
                            return reader.GetInt32(reader.GetOrdinal("id"));
                        }
                    }
                    }
                }
            }
            catch (MySqlException mySqlEx)
            {
                // 处理数据库相关的异常
                Console.WriteLine("Database error: " + mySqlEx.Message);
                return null;
            }
            finally
            {
                dbUtil.CloseCon();
            }
            return null; // 如果没有找到用户名，返回 null
        }
    }
}