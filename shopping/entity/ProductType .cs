using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping.entity
{
    internal class ProductType
    {
        public int TypeID { get; set; } // 主键，商品类型的唯一标识符
        public string TypeName { get; set; } // 商品类型的名称
    }
}
