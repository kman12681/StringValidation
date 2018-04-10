using System;


namespace StringValidation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a three digit number: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Now enter another three digit number: ");
            string num2 = Console.ReadLine();

            int a = num1[0];
            int b = num1[1];
            int c = num1[2];

            int x = num2[0];
            int y = num2[1];
            int z = num2[2];

            if (((a+x) == (b+y)) && ((b+y) == (c+z)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

        }
    }
}
