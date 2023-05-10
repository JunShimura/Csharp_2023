namespace Ex06
{
    internal class Ex06
    {
        static void Main(string[] args)
        {
            Console.Write("身長の入力(cm):");
            double height;//身長
            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            double weight;
            Console.Write("体重の入力(kg):");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            height /= 100;
            var bmi = weight / (height * height);  // BMIを算出
            var s = $"身長={height},体重={weight},\nBMI={bmi.ToString("F2")}\n";
            if (bmi < 18.5)//18.5未満 低体重(痩せ型)
            {
                s += "低体重(痩せ型)";
            }
            else if (bmi < 25)//18.5〜25未満 普通体重
            {
                s += "普通体重";
            }
            else if (bmi < 30)//25〜30未満 肥満(1度)
            {
                s += "肥満(1度)";
            }
            else if (bmi < 35)//30〜35未満 肥満(2度)
            {
                s += "肥満(2度)";
            }
            else if (bmi < 40)//35〜40未満 肥満(3度)
            {
                s += "肥満(3度)";
            }
            else//40以上 肥満(4度)
            {
                s += "肥満(4度)";
            }
            Console.WriteLine(s);
        }
    }
}