using SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Services
{
    internal class ProductFetcher : IProductFetcher
    {
        public void FetchProduct()
        {
            Console.WriteLine("Fetching product from database...");
        }
    }
}
