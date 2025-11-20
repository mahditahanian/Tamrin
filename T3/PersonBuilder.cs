using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin.T3
{
    public class PersonBuilder
    {
        protected Person person = new Person();
        public PersonInfoBuilder Info => new PersonInfoBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);


        public Person Build() { return person; }
    
    }
}
