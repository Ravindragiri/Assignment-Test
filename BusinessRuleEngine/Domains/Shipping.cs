using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Domains
{
    public class Shipping
    {
        public PackingSlip GeneratePackingSlip()
        {
            Console.WriteLine("Generating packing slip for shipping");
            return new PackingSlip();
        }
    }
}
