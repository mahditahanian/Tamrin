using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin.T3
{
    public class Person
    {
        public string Name { get; set; }
        public Job Job { get; set; }


        public override string ToString()
        {

            return $"Name:{Name}\n " +
                $"At {Job.Company}\n" +
                $"Job {Job.At}";
        }
    }
}
