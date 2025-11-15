using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.T2.Spec;

namespace Tamrin.T2.Pred
{
    public class NameContainsSpecification : ISpecification<User>
    {
        private readonly string _text;

        public NameContainsSpecification(string text)
        {
            _text = text;
        }

        public bool IsSatisfiedBy(User candidate)
            => !string.IsNullOrEmpty(candidate.Name) &&
               candidate.Name.Contains(_text, StringComparison.OrdinalIgnoreCase);
    }
}
