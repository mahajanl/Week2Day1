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
            //int[] favNumbers = { 1, 2, 3, 4, 5, 6, };

            //string[] studentNames = { "Raz", "Kevin", "Shane", "Katy" };

            //Console.WriteLine(favNumbers[3]);
            //Console.WriteLine(studentNames[1]);

            //string[] vacaSpots = { "Ireland", "Colorado", "Italy", "San Fransisco", "Sedona", "Cincinnati", "Cape Cod", "Frederick", "New Mexico", "New York" };
            //Console.WriteLine(vacaSpots[0] + " " + vacaSpots[9]);

            //int[] kidsIKnow = { 2, 11, 3 };
            //Console.WriteLine(kidsIKnow[0]);
            //Console.WriteLine(kidsIKnow[1]);
            //Console.WriteLine(kidsIKnow[2]);

            //double[] gpas = { 3.1, 3.56, 3.21, 3.9, 3.95, 2.9, 3.33, 2.98};
            //Console.WriteLine(gpas[2]);

            //char[] peerNames = { 's', 'r', 't', 'd' };
            //Console.WriteLine(peerNames[3]);

            ////when you don't know the elements up front
            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[2] + " " + numbers[3]);

            //string [] daysOfWeek = new string [7];
            //daysOfWeek[0] = "Monday";
            //daysOfWeek[1] = "Tuesday";
            //daysOfWeek[2] = "Wednesday";
            //daysOfWeek[3] = "Thursday";
            //daysOfWeek[4] = "Friday";
            //daysOfWeek[5] = "Saturday";
            //daysOfWeek[6] = "Sunday";
            //Console.WriteLine(daysOfWeek.Length);


            //int[] studentAges = new int[5];
            //studentAges[0] = 19;
            //studentAges[1] = 17;
            //studentAges[2] = 18;
            //studentAges[3] = 25;
            //studentAges[4] = 21;

            //char[] lastNAme = { 'm', 'a', 'h', 'a', 'j', 'a', 'n' };
            //char[] myLastName = new char[7];
            //Console.WriteLine(myLastName.Length);

            string[] streetNames = { "Grafton", "Main", "First", "hi", "you", "in", "anger", "don't", "look" };
            Console.WriteLine("This is the last index " + (streetNames.Length - 1));

            //int index = streetNames.Length;
            //int secondToLast = index - 2;

            //Console.WriteLine(streetNames[secondToLast]);





        }
    }
}
