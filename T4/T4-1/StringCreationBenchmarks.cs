using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin.T4.T4_1
{
    public class StringCreationBenchmarks
    {
        private const string FirstName = "mahdi";
        private const string LastName = "tahanian";
        private const int Age = 37;
        private const double Salary = 70765.43;

        [Benchmark(Baseline = true)]
        /// <summary> 
        /// تبدیل میشه به
        // string.Format
        // واسه همین یه مقدار
        // overhead
        // داره
        ///
        /// </summary>
        public string StringInterpolation() 


            => $"Name: {FirstName} {LastName}, Age: {Age}, Salary: {Salary:N2}";

        [Benchmark]

        /// <summary> 
        /// این تبدیل میشه به
        // string.Concat
        // واسه همین سریعتره
        /// </summary>
        public string Concatenation() 
            => "Name: " + FirstName + " " + LastName + ", Age: " + Age + ", Salary: " + Salary.ToString("N2");

        [Benchmark]
        public string StringFormat()
            => string.Format("Name: {0} {1}, Age: {2}, Salary: {3:N2}", FirstName, LastName, Age, Salary);

        [Benchmark]
        public string StringBuilderMethod()
        {
            var sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(FirstName);
            sb.Append(' ');
            sb.Append(LastName);
            sb.Append(", Age: ");
            sb.Append(Age);
            sb.Append(", Salary: ");
            sb.Append(Salary.ToString("N2"));
            return sb.ToString();
        }
        
        private const int Loops = 10_000;
        //با این  هر بار شی جدید میسازه و حافظه زیاد میگیره و  گاربیج کالکتور میره زیر فشار
        [Benchmark]

        public string ConcatInLoop()
        {
            string result = "";
            for (int i = 0; i < Loops; i++)
                result += "A";
            return result;
        }
        /// <summary>
        ///  سریعتره
        ///  این انگار یه شی میسازه 
        /// این نتیجه عالی بود
        /// </summary>
        [Benchmark]
        public string BuilderInLoop()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Loops; i++)
                sb.Append("A");
            return sb.ToString();
        }
    }
}
