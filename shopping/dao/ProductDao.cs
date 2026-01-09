using MySql.Data.MySqlClient;
using shopping.entity;
using shopping.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping.dao
{
    internal class ProductDao
    {
        private DbUtil dbUtil = DbUtil.Instance;
        private static ProductDao _instance;
        private ProductDao() { }

        public static ProductDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductDao();
                }
                return _instance;
            }
        }

        // 添加新产品到数据库
        public void AddProduct(Product product)
        {
            try
            {
                dbUtil.GetCon(); // 获取数据库连接
                using (dbUtil.conn)
                {
                    // 先根据 ProductType 表中的 TypeName 查询对应的 TypeID
                    string typeIDQuery = "SELECT TypeID FROM ProductType WHERE TypeName = @TypeName LIMIT 1";
                    int productTypeID = 0; // 用于存储查询到的 TypeID

                    using (MySqlCommand typeCmd = new MySqlCommand(typeIDQuery, dbUtil.conn))
                    {
                        // 添加查询参数
                        typeCmd.Parameters.AddWithValue("@TypeName", product.ProductTypeName); // 假设传入的 product 对象有 TypeName 属性
                        object result = typeCmd.ExecuteScalar();

                        if (result != null)
                        {
                            productTypeID = Convert.ToInt32(result); // 获取查询到的 TypeID
                        }
                        else
                        {
                            // 如果没有找到对应的 TypeID，可以抛出异常或做其他处理
                            MessageBox.Show("未找到对应的产品类型!");
                            return;
                        }
                    }

                    // 使用查询到的 productTypeID 进行插入操作
                    string query = "INSERT INTO ProductInfo (ProductTypeID, SupplierName, ProductCode, ProductName, RetailPrice, ProductNumber, ProductionDate, ShelfLifeDays) " +
                                   "VALUES (@ProductTypeID, @SupplierName, @ProductCode, @ProductName, @RetailPrice, @ProductNumber, @ProductionDate, @ShelfLifeDays)";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        // 添加插入参数并赋值
                        cmd.Parameters.AddWithValue("@ProductTypeID", productTypeID); // 使用查询到的 TypeID
                        cmd.Parameters.AddWithValue("@SupplierName", product.SupplierName);
                        cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                        cmd.Parameters.AddWithValue("@RetailPrice", product.RetailPrice);
                        cmd.Parameters.AddWithValue("@ProductNumber", product.ProductNumber);
                        cmd.Parameters.AddWithValue("@ProductionDate", product.ProductionDate);
                        cmd.Parameters.AddWithValue("@ShelfLifeDays", product.ShelfLifeDays);

                        // 执行插入操作
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 如果受影响的行数大于0，则表示添加成功
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("产品添加成功!");
                        }
                        else
                        {
                            MessageBox.Show("产品添加失败!");
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("编码重复");
            }
            finally
            {
                dbUtil.CloseCon();
            }
        }

        // 更新数据库中的产品信息
        public void UpdateProduct(string productCode, float newPrice)
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
                string query = "UPDATE ProductInfo SET RetailPrice = @NewPrice WHERE ProductCode = @ProductCode";
                MySqlCommand command = new MySqlCommand(query, dbUtil.conn);
                command.Parameters.AddWithValue("@ProductCode", productCode);
                command.Parameters.AddWithValue("@NewPrice", newPrice);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} rows were updated.");
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

        // 根据产品ID删除数据库中的产品
        public void DeleteProduct(string productCode)
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
                string query = "DELETE FROM ProductInfo WHERE ProductCode = @ProductCode";
                MySqlCommand command = new MySqlCommand(query, dbUtil.conn);
                command.Parameters.AddWithValue("@ProductCode", productCode);

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

        // 根据产品名称从数据库中获取产品信息
        public BindingList<Product> GetProductByName(string productName)
        {
            BindingList<Product> productList = new BindingList<Product>();
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT pt.TypeName AS ProductTypeName, p.SupplierName, p.ProductCode, p.ProductName, p.RetailPrice, p.ProductionDate," +
                        " p.ShelfLifeDays, p.ProductNumber FROM ProductInfo p JOIN ProductType pt ON p.ProductTypeID = pt.TypeID WHERE p.ProductName LIKE @ProductName;";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 添加查询参数
                    command.Parameters.AddWithValue("@ProductName", "%"+productName+"%"); 
                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            Product product = new Product
                            {
                                ProductTypeName = reader.GetString("ProductTypeName"),
                                SupplierName = reader.GetString("SupplierName"),
                                ProductCode = reader.GetString("ProductCode"),
                                ProductName = reader.GetString("ProductName"),
                                RetailPrice = reader.GetFloat("RetailPrice"),
                                ProductionDate = reader.GetDateTime("ProductionDate"),
                                ShelfLifeDays = reader.GetInt32("ShelfLifeDays"),
                                ProductNumber = reader.GetInt32("ProductNumber")
                            };

                            // 将 ProductInfo 对象添加到 BindingList 中
                            productList.Add(product);
                        }
                    }
                    return productList;
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
        }

        // 从数据库中获取所有产品信息
        public BindingList<Product> GetAllProducts()
        {
            BindingList<Product> productList = new BindingList<Product>();
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT pt.TypeName AS ProductTypeName, p.SupplierName, p.ProductCode, p.ProductName, p.RetailPrice," +
                        " p.ProductionDate, p.ShelfLifeDays, p.ProductNumber FROM ProductInfo p JOIN ProductType pt ON p.ProductTypeID = pt.TypeID;";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            Product product = new Product
                            {
                                ProductTypeName = reader.GetString("ProductTypeName"),
                                SupplierName = reader.GetString("SupplierName"),
                                ProductCode = reader.GetString("ProductCode"),
                                ProductName = reader.GetString("ProductName"),
                                RetailPrice = reader.GetFloat("RetailPrice"),
                                ProductionDate = reader.GetDateTime("ProductionDate"),
                                ShelfLifeDays = reader.GetInt32("ShelfLifeDays"),
                                ProductNumber = reader.GetInt32("ProductNumber")
                            };

                            // 将 ProductInfo 对象添加到 BindingList 中
                            productList.Add(product);
                        }
                    }
                    return productList;
                }
            }
            catch(MySqlException mySqlEx)
            {
                MessageBox.Show("sql错误"+ mySqlEx.Message);
                return null;
            }
            finally
            {
                dbUtil.CloseCon();
            }

        }

        // 获取所有的产品类别信息。
        public BindingList<ProductType> GetALLType()
        {
            BindingList<ProductType> typeList = new BindingList<ProductType>();
            try
            {
                dbUtil.GetCon(); // 获取数据库连接
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT TypeName,TypeID FROM ProductType;";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            ProductType Type = new ProductType
                            {
                                TypeName = reader.GetString("TypeName"),
                                TypeID = reader.GetInt32("TypeID")
                            };
                            // 将 ProductInfo 对象添加到 BindingList 中
                            typeList.Add(Type);
                        }
                    }
                    return typeList;
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
                dbUtil.CloseCon(); // 关闭数据库连接
            }
        }
        
        // 根据产品种类名称模糊查询产品种类
        public BindingList<ProductType> GetALLTypeByName(string TypeName)
        {
            BindingList<ProductType> typeList = new BindingList<ProductType>();
            try
            {
                dbUtil.GetCon(); // 获取数据库连接
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT TypeName,TypeID FROM ProductType WHERE TypeName LIKE @TypeName;";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 添加查询参数
                    command.Parameters.AddWithValue("@TypeName", "%" + TypeName + "%");

                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            ProductType Type = new ProductType
                            {
                                TypeName = reader.GetString("TypeName"),
                                TypeID = reader.GetInt32("TypeID")
                            };
                            // 将 ProductInfo 对象添加到 BindingList 中
                            typeList.Add(Type);
                        }
                    }
                    return typeList;
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
                dbUtil.CloseCon(); // 关闭数据库连接
            }
        }

        // 添加新产品种类到数据库
        public bool AddProductType(string TypeName) {
            try
            {
                dbUtil.GetCon(); // 获取数据库连接
                using (dbUtil.conn)
                {
                    string query = "INSERT INTO ProductType (TypeName) VALUES (@TypeName);";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        // 添加参数并赋值
                        cmd.Parameters.AddWithValue("@TypeName", TypeName);
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
                dbUtil.CloseCon(); // 关闭数据库连接
            }
        }

        // 获取过期商品信息
        public BindingList<Product> GetExpireProducts()
        {
            BindingList<Product> productList = new BindingList<Product>();
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT pt.TypeName AS ProductTypeName, p.SupplierName, p.ProductCode, p.ProductName, p.RetailPrice, p.ProductionDate, p.ShelfLifeDays, p.ProductNumber FROM ProductInfo p JOIN ProductType pt ON p.ProductTypeID = pt.TypeID WHERE DATE_ADD(p.ProductionDate, INTERVAL p.ShelfLifeDays DAY) < CURDATE();";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            Product product = new Product
                            {
                                ProductTypeName = reader.GetString("ProductTypeName"),
                                SupplierName = reader.GetString("SupplierName"),
                                ProductCode = reader.GetString("ProductCode"),
                                ProductName = reader.GetString("ProductName"),
                                RetailPrice = reader.GetFloat("RetailPrice"),
                                ProductionDate = reader.GetDateTime("ProductionDate"),
                                ShelfLifeDays = reader.GetInt32("ShelfLifeDays"),
                                ProductNumber = reader.GetInt32("ProductNumber")
                            };

                            // 将 ProductInfo 对象添加到 BindingList 中
                            productList.Add(product);
                        }
                    }
                    return productList;
                }
            }
            catch (MySqlException mySqlEx)
            {
                MessageBox.Show("sql错误" + mySqlEx.Message);
                return null;
            }
            finally
            {
                dbUtil.CloseCon();
            }

        }

        // 添加商品界面，获取种类名称信息
        public BindingList<ProductType> GetAllType()
        {
            BindingList<ProductType> productList = new BindingList<ProductType>();
            try
            {
                dbUtil.GetCon();
                using (dbUtil.conn)
                {
                    // 编写 SQL 查询语句
                    string query = "SELECT TypeName FROM ProductType;";

                    // 创建 MySQL 命令对象
                    MySqlCommand command = new MySqlCommand(query, dbUtil.conn);

                    // 执行查询并获取结果
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建 ProductInfo 对象并填充数据
                            ProductType producttype = new ProductType
                            {
                                TypeName = reader.GetString("TypeName"),
                            };

                            // 将 ProductInfo 对象添加到 BindingList 中
                            productList.Add(producttype);
                        }
                    }
                    return productList;
                }
            }
            catch (MySqlException mySqlEx)
            {
                MessageBox.Show("sql错误" + mySqlEx.Message);
                return null;
            }
            finally
            {
                dbUtil.CloseCon();
            }

        }

        // 根据种类Id从数据库中删除产品种类
        public bool DeleteProductType(int TypeID) {
            try
            {
                dbUtil.GetCon(); // 获取数据库连接
                using (dbUtil.conn)
                {
                    string query = "DELETE FROM ProductType WHERE TypeID = @TypeID";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbUtil.conn))
                    {
                        // 添加参数并赋值
                        cmd.Parameters.AddWithValue("@TypeID", TypeID);
                        // 执行删除操作
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // 如果受影响的行数大于0，则表示删除成功
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
                dbUtil.CloseCon(); // 关闭数据库连接
            }
        }
    }
}
