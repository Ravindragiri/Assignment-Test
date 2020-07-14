using BusinessRuleEngine.Domains;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Extensions;

namespace BusinessRuleEngine.Engine
{
    public class PaymentManager
    {
        public void ProcessPayment(Payment payment)
        {
            payment.CheckForFreeProduct();

            foreach (var product in payment.Products)
            {
                ProcessProduct(product);
            }
        }

        private void ProcessProduct(Product product)
        {
            if (product.IsPhysicalProduct)
            {
                //generate packing slip for shipping
                var packingSlip = new Shipping().GeneratePackingSlip();
                
                if (product.ProductCategory == ProductCategory.Book)
                {
                    //create duplicate packing slip for Royalty
                    new Royalty().CreateDuplicatePackingSlip(packingSlip);
                }

                //generate commission payment to agent
                new Agent().GenerateCommission(product.Amount);
            }
            else
            {
                if (product.ProductCategory == ProductCategory.NewMembership)
                {
                    //activate the membership
                    new Membership().Activate();
                }
                if (product.ProductCategory == ProductCategory.UpgradeMembership)
                {
                    //apply the membership upgrade
                    new Membership().Upgrade();
                }
            }
            
        }
    }
}
