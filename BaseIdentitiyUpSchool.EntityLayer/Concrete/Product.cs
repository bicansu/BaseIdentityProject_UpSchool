using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseIdentitiyUpSchool.EntityLayer.Concrete
{
    public class Product
    {
        public int productID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPice { get; set; }
        public string ProductImage { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
