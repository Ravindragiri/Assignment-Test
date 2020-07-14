using BusinessRuleEngine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Domains
{
    public class Membership
    {
        public void Activate()
        {
            Console.WriteLine("Activating the membership");
            EmailHelper.SendEmail("Email Sent: Activating the membership");
        }

        public void Upgrade()
        {
            Console.WriteLine("Upgrading the membership");
            EmailHelper.SendEmail("Email Sent: Upgrading the membership");
        }
    }
}
