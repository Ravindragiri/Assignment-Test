using BusinessRuleEngine.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Extensions
{
    public static class PaymentExtension
    {
        public static void CheckForFreeProduct(this Payment payment)
        {
            var freeProducts = payment.Products.Where(e=> e.FreeProducts != null && e.FreeProducts.Any())
                .SelectMany(e => e.FreeProducts).ToList();
            if (freeProducts != null && freeProducts.Any())
            {
                payment.Products.AddRange(freeProducts);
                //payment.Products.Add(new Product() { Name = "First Aid" });
            }
        }
    }
}
