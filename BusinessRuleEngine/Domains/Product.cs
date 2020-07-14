using BusinessRuleEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Domains
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public List<Product> FreeProducts { get; set; }
        public bool IsPhysicalProduct { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
