using System;

namespace Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Letting the user know what is about to happen.
            Console.WriteLine("Let's manually populate an array with integers.");
            Console.WriteLine("Then, let's iterate through the elements in array with a for loop.");
            //Automatically populate an array
            int[] numArray = new int[] { 101, 201, 301, 401, 501, 601, 701, 801, 901, 102, 112, 122, 132, 142, 152, 162, 172, 182, 192, 202, 212, 222, 232, 242, 252 };
            //The elemt number is 0 where the value of the element is 1. It increases by one from there. 
            //loop that displays the element number and value
            for (int i = 0; i < numArray.Length; i++) 
            {
                Console.WriteLine("Element Number: " + i + " --Element Value" + " " + numArray[i]);
            }

        }
    }
}
