﻿namespace Ex04
{
    internal class Ex04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("金額を入力：");
            var money = uint.Parse(Console.ReadLine());
            var k10000 = money / 10000;
            Console.WriteLine($"1万円札:{k10000}枚");
            money %= 10000;
            var k5000 = money / 5000;
            Console.WriteLine($"五千円札:{k5000}枚");
            money %= 5000;
            var k1000 = money / 1000;
            Console.WriteLine($"千円札:{k1000}枚");
            money %= 1000;
            var k500 = money / 500;
            Console.WriteLine($"五百円玉:{k500}枚");
            money %= 500;
            var k100 = money / 100;
            Console.WriteLine($"百円玉:{k100}枚");
            money %= 100;
            var k50 = money / 50;
            Console.WriteLine($"五十円玉:{k50}枚");
            money %= 50;
            var k10 = money / 10;
            Console.WriteLine($"十円玉:{k10}枚");
            money %= 10;
            var k5 = money / 5;
            Console.WriteLine($"五円玉:{k5}枚");
            money %= 5;
            var k1 = money / 1;
            Console.WriteLine($"一円玉:{k1}枚");
        }
    }
}