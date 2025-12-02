using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T4.T4_2.Model;

namespace Tamrin.T4.T4_2
{
    public interface ITransferStrategy
    {
        bool Transfer(Package package);
    }
}
