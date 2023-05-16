namespace Ex08_2
{
    internal class Ex08_2
    {
        static void Main(string[] args)
        {
            double income;
            Console.Write("年収（入力は万円単位）を入力：");
            if (!double.TryParse(Console.ReadLine(), out income))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            double height;
            Console.Write("身長（入力は㎝単位）を入力：");
            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            if (income >= 1000 && height >= 180)//大好き！"
            {
                //年収が理想、かつ、身長が理想
                Console.WriteLine("大好き！");
            }
            else if (income >= 1000 || height >= 180)
            {
                //年収が理想、かつ、身長が理想じゃない
                Console.WriteLine("おしい");

            }
            else
            {
                Console.WriteLine("論外ね");
            }

        }

    }
}