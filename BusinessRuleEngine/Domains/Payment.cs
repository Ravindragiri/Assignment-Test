using BusinessRuleEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Domains
{
    public class Payment
    {
        public Payment()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public Agent Agent { get; set; }
    }
}
