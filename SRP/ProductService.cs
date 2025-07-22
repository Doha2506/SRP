using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class ProductService
    {
        public void ProcessProduct()
        {
            // 1. Fetch product from database
            Console.WriteLine("Fetching product from database...");

            // 2. Save log to file
            Console.WriteLine("Logging: Product fetched at " + DateTime.Now);

            // 3. Send notification email
            Console.WriteLine("Sending email: Product fetched.");
        }
    }

}
