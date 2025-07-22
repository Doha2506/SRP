using SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Services
{
    internal class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
