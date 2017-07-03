using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables

            int miles = 30;
            int totalMiles = 47;
            
            //initialize variables and output

            Console.WriteLine("We need to solve a Problem");
            Console.WriteLine("If Julia ran 30 more miles than Pravav, and her total was 47 miles\nhow many miles did Pravav run?");
            int subtotal = totalMiles - miles;
            Console.WriteLine("Pravavs total miles were " + subtotal);

        }
    }
}
