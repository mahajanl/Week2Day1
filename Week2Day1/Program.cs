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

            Console.WriteLine(favNumbers[3]);
            Console.WriteLine(studentNames[1]);

            string[] vacaSpots = { "Ireland", "Colorado", "Italy", "San Fransisco", "Sedona", "Cincinnati", "Cape Cod", "Frederick", "New Mexico", "New York" };
            Console.WriteLine(vacaSpots[0] + " " + vacaSpots[9]);

            int[] kidsIKnow = { 2, 11, 3 };
            Console.WriteLine(kidsIKnow[0]);
            Console.WriteLine(kidsIKnow[1]);
            Console.WriteLine(kidsIKnow[2]);

            double[] gpas = { 3.1, 3.56, 3.21, 3.9, 3.95, 2.9, 3.33, 2.98};
            Console.WriteLine(gpas[2]);

            char[] peerNames = { 's', 'r', 't', 'd' };
            Console.WriteLine(peerNames[3]);
           

        }
    }
}
