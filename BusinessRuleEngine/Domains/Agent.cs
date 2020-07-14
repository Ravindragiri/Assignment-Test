using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Domains
{
    public class Agent
    {
        public decimal Commission { get; set; }

        public void GenerateCommission(decimal amount)
        {
            Console.WriteLine("generating commission payment to agent");
        }
    }
}
