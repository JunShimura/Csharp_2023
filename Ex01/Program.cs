namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("身長の入力(cm):");
            var height = double.Parse(Console.ReadLine()); //身長
            Console.Write("体重の入力(kg):");
            var weight = double.Parse(Console.ReadLine()); ; // 体重
            var bmi = weight / ((height / 100) * (height / 100)); // BMIを求める数式
            Console.Write($"身長={height},体重={weight},\nBMI={bmi}");
        }
    }
}