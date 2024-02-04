// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Sapar!");

namespace FibonacciApps
{
    class Program
    {
        static void Main(string[] args)
        {
            BilanganFibonacci();
            Console.WriteLine(" ");
            BilanganGenap();
        }

        static void BilanganFibonacci()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------Bilangan Fibonacci--------------------");
            Console.WriteLine("-----------------------------------------------------------");

            int nmbr1 = 0, nmbr2 = 1, nmbr3, value;
            Console.Write("Please input of number : ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.Write(nmbr1 + " " + nmbr2 + " ");

            for (int i = 2; i < value; i++)
            {
                nmbr3 = nmbr1 + nmbr2;
                Console.Write(nmbr3 + " ");
                nmbr1 = nmbr2;
                nmbr2 = nmbr3;
            }
            
        }

        static void BilanganGenap()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------Bilangan Genap------------------------");
            Console.WriteLine("-----------------------------------------------------------");

            int calc = 1, count = 0, value;

            Console.Write("Please input of number : ");
            value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; calc <= value; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }

                count += 1;
                calc++;
            }
        }
    }

}
