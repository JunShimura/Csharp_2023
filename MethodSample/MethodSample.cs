using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace MethodSample
{
    internal class MEthodSample
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("身長の入力(cm):");
            var height = double.Parse(Console.ReadLine()); //身長
            Console.Write("体重の入力(kg):");
            var weight = double.Parse(Console.ReadLine());  // 体重
            */
            var name = InputString("名前を入力：");
            var height = InputNumber("身長の入力(cm):", 100, 300);
            var weight = InputNumber("体重の入力(kg):");
            height /= 100;
            var bmi = weight / (height * height);  // BMIを算出
            Console.Write($"{name}さんの身長={height},体重={weight},\nBMI={bmi.ToString("F2")}");
        }
        private static string InputString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static double InputNumber(string message)
        {
            double i;
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out i))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
            }
            return i;
        }

        private static double InputNumber(string message, double min, double max)
        {
            double i;
            while (true)
            {
                i = InputNumber($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine("入力範囲エラー");
            }
            return i;
        }


        private static int InputInt(string message)
        {
            int i;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
            }
            return i;
        }

        private static int InputInt(string message, int min, int max)
        {
            int i;
            while (true)
            {
                i = InputInt($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine("入力範囲エラー");
            }
            return i;
        }
    }
}