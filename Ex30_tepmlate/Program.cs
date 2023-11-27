using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(DateTime.Now, "デジタル太郎", 0.5f, 160f, 50f);
            Console.WriteLine("Hello World!");
        }
    }
}
