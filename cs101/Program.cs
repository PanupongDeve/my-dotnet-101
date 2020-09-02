using System;
using DesignPattern;

namespace cs101
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
            Singleton singleton2 = Singleton.getInstance();

            Console.WriteLine(singleton.sayHello());
            Console.WriteLine(singleton2.sayHello());
        }
    }
}
