using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T2.Spec;

namespace Tamrin.T2.Pred
{
    public class IsAdminSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User candidate)
            => candidate != null && candidate.IsAdmin;
    }
}
