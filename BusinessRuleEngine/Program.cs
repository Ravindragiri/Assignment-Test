using BusinessRuleEngine.Domains;
using BusinessRuleEngine.Engine;
using BusinessRuleEngine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentManager paymentManager = new PaymentManager();
            Payment payment = GetDummyPayment();
            paymentManager.ProcessPayment(payment);

            foreach (var product in payment.Products)
            {
                Console.WriteLine(string.Format("Product Name: {0}, Amount: {1}", product.Name, product.Amount));
            }
            Console.ReadKey();
        }

        private static Payment GetDummyPayment()
        {
            var freeProduct = new List<Product>()
            {
                new Product() { IsPhysicalProduct=true, Name="First Aid", Amount=100 }
            };

            return new Payment()
            {
                Products = new List<Product>()
                {
                    new Product() { IsPhysicalProduct=true, Name="Book", ProductCategory=ProductCategory.Book, Amount=200 },
                    new Product() { ProductCategory=ProductCategory.NewMembership, Name="New Membership", Amount=300 },
                    new Product() { IsPhysicalProduct=true, Name="Learning To Ski", ProductCategory=ProductCategory.Video, FreeProducts = freeProduct, Amount=400 }
                }
            };
        }
    }
}
