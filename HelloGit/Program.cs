using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? greaterThan = new DateTime(2007, 1, 1);

            if (greaterThan.HasValue)
            {
                if (greaterThan.Value < new DateTime(2000, 1, 1) || greaterThan.Value > DateTime.Now)
                {
                    Console.WriteLine(string.Format("Wrong date. GreaterThanDate: {0} must be between 2000-01-01 00:00:00 and {1}", greaterThan.Value.ToString("u"), DateTime.Now.ToString("u")));
                }
            }


            //Your code goes here
            Console.WriteLine("Hello, Git!");
            Console.ReadLine();
        }
    }
}
