using System;

namespace DesignPatternsFabrica
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ferraryFactory = new FerraryFactory();
            var bmWFactory = new BMWFactory();
            ferraryFactory.Create();
            bmWFactory.Create();
            Console.WriteLine("Hello World!");
        }
    }
}