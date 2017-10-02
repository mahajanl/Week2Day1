using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is declaring - when i give it a value, i initialize it
            // for the sake of example: int favNumber;
            //this is how i declare an array - this is an empty array
            // int [] favNums;

            //                    these are the elements we're storing in the array - 6 elements, index 0-5
            int[] favNumbers = { 1, 2, 3, 4, 5, 6, };

            string[] studentNames = { "Raz", "Kevin", "Shane", "Katy" };

            Console.WriteLine(studentNames[1]);
        }
    }
}
