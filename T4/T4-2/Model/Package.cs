using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin.T4.T4_2.Model
{
    public class Package
    {
        public required string Name { get; set; }
        public int Weight { get; set; }        
        public string? Description { get; set; }

        public ITransferStrategy Strategy { get; set; } 

        public bool Transfer()
        {
            return Strategy.Transfer(this);
        }
    }
}
