using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T2.Spec;

namespace Tamrin.T2.Pred
{
    public class AgeGreaterThanSpecification : ISpecification<User>
    {
        private readonly int _minAge;

        public AgeGreaterThanSpecification(int minAge)
        {
            _minAge = minAge;
        }

        public bool IsSatisfiedBy(User candidate)
            => candidate.Age > _minAge;
    }

}
