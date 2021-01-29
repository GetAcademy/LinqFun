using System;
using System.Linq;
using System.Net;

namespace LinqFun
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeDemo.Run();
            return;

            var numbers =
                new NumberSequence()
                    .Select(DoubleIt)
                    .Select(Add1)
                    .AsParallel();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            //var orders = new Order[20];
            //foreach (var o in orders)
            //{
            //    Cook(o);
            //    Deliver(o);
            //}
            //DoSomething<int>(5);
            //DoSomething<string>("jhgjh");
        }

        private static int Add1(int n)
        {
            Console.WriteLine($"Legger 1 til {n} = {n+1}");
            return n + 1;
        }

        private static int DoubleIt(int n)
        {
            Console.WriteLine($"Dobler {n} = {n*2}");
            return n * 2;
        }

        //static void DoSomething<T>(T value) 
        //{
        //    Console.WriteLine(value);
        //}
    }
}
