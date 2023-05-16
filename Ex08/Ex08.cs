namespace Ex08
{
    internal class Ex08
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
            if (income >= 1000)//年収が理想か判定
            {
                //年収が理想
                if (height >= 180)//身長が理想か判定
                {
                    //年収が理想、かつ、身長が理想
                    Console.WriteLine("大好き！");
                }
                else
                {
                    //年収が理想、かつ、身長が理想じゃない
                    Console.WriteLine("おしい");
                }
            }
            else
            {
                //年収が理想じゃない
                if (height >= 180)//身長が理想か判定
                {
                    //年収が理想じゃない、かつ、身長が理想
                    Console.WriteLine("おしい");
                }
                else
                {
                    //年収が理想じゃない、かつ、身長が理想じゃない
                    Console.WriteLine("論外ね");
                }
            }
        }
    }
}