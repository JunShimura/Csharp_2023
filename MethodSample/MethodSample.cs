using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace MethodSample
{
    internal class MethodSample
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("身長の入力(cm):");
            var height = double.Parse(Console.ReadLine()); //身長
            Console.Write("体重の入力(kg):");
            var weight = double.Parse(Console.ReadLine());  // 体重
            */
            var name = InputUtility.InputString("名前を入力：");
            var height = InputUtility.InputNumber("身長の入力(cm):", 100, 300,"うそはだめですよ");
            var weight = InputUtility.InputNumber("体重の入力(kg):",10,500);
            height /= 100;
            var bmi = weight / (height * height);  // BMIを算出
            Console.Write($"{name}さんの身長={height},体重={weight},\nBMI={bmi.ToString("F2")}");
        }
    }
    //使うときはここからコピー==============

    /// <summary>
    /// Input用の汎用class
    /// </summary>
    class InputUtility
    {
        public static bool isNaturalNumberOr0(double number)
        {
            return (number == 0 || isNaturalNumber(number));
        }
        public static bool isNaturalNumber(double number)
        {
            return (number > 0 && Math.Floor(number) == number);
        }

        public static string InputString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static double InputNumber(string message)
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

        public static double InputNumber(string message, double min, double max,string errMessage= "入力範囲エラー")
        {
            double i;
            while (true)
            {
                i = InputNumber($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine(errMessage);
            }
            return i;
        }

        public static int InputInt(string message)
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



        public static int InputInt(string message, int min, int max,string errMessage= "入力範囲エラー")
        {
            int i;
            while (true)
            {
                i = InputInt($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine(errMessage);
            }
            return i;
        }
    }

    // ここまでコピー==============


}