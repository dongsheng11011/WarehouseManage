using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping.entity
{
    internal class Product
    {
        public int ProductID { get; set; }      //商品id
        public int ProductTypeID { get; set; }  //商品种类id
        public string ProductTypeName { get; set; }
        public string SupplierName { get; set; }     // 厂商
        public string ProductCode { get; set; } // 商品的编号
        public string ProductName { get; set; } // 商品的名称
        public float RetailPrice { get; set; } // 商品的零售价格
        public DateTime ProductionDate { get; set; } // 商品的生产日期
        public int ShelfLifeDays { get; set; } // 商品的保质期（以天数表示）
        public int ProductNumber { get; set; } // 商品的件数

        // 计算过期天数
        public int ExpirationDays
        {
            get
            {
                // 当前日期减去生产日期，并计算过期天数
                var expirationDate = ProductionDate.AddDays(ShelfLifeDays);
                var daysUntilExpiration = ( DateTime.Now - expirationDate).Days;
                return daysUntilExpiration;
            }
        }
    }
}
