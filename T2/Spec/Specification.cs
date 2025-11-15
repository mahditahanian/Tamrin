using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T2.Enum;

namespace Tamrin.T2.Spec
{
    public class Specification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> operand;
        private readonly List<(LogicalOperator op, ISpecification<T> spec)> _rest;

        public Specification(
            ISpecification<T> first,
            IEnumerable<(LogicalOperator op, ISpecification<T> spec)> rest)
        {
            operand = first ?? throw new ArgumentNullException(nameof(first));
            _rest = rest?.ToList() ?? new List<(LogicalOperator, ISpecification<T>)>();
        }

        public bool IsSatisfiedBy(T candidate)
        {
            // عملوندها 
            bool result = operand.IsSatisfiedBy(candidate);

            // عملگرها
            foreach (var (op, spec) in _rest)
            {
                bool current = spec.IsSatisfiedBy(candidate);

                switch (op)
                {
                    case LogicalOperator.And:
                        result = result && current;
                        break;

                    case LogicalOperator.Or:
                        result = result || current;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(op), op, null);
                }
            }

            return result;
        }
    }

}
