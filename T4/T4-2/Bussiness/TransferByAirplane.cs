using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T4.T4_2.Model;

namespace Tamrin.T4.T4_2.Interface
{
    public class TransferByAirplane : ITransferStrategy
    {
        public bool Transfer(Package package)
        {
            Console.WriteLine($"[Airplane] Package {package.Name} ({package.Weight} kg) shipped.");
            
            return true;
        }
    }
}
