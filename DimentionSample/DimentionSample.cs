using System;

namespace DimentionSample
{
    internal class DimentionSample
    {
        static void Main(string[] args)
        {
            //　配列でとる
            const int numMember = 5;
            double[] tall = new double[numMember];
            for (var i = 0;i<numMember; i ++ ){
                Console.Write($" {i} 番目の身長 : ");
                tall[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("何番目の身長を知りたいですか?");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}番目の人の身長は{tall[x]}です。");

        }
    }
}