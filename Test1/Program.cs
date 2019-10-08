using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of a string variable
            string b = "Banana";

            // Making a new object of class program to invoc its function
            // Instead of making it static
            Program frase = new Program();

            // Call function Hello and set local variable b as parameter
            frase.Hello(b);

            // Print out the output of the programm
            Console.WriteLine(b);

        }

        /// <summary>
        /// Funtion to test out reference types in Heap
        /// </summary>
        /// <param name="a"> Receives a string as parameter</param>
        public void Hello(string a)
        {
            a = "hi";
        }
    }
}
