namespace Ex07
{
    internal class Ex07
    {
        static void Main(string[] args)
        {
            double weight;
            Console.Write("体重の入力(kg):");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("入力エラー");
                return;
            }
            if (weight < 30.0)
            {
                Console.WriteLine($"ガリガリ\n{30 - weight}kg足りません");
            }
            else if (weight < 80.0)
            {
                Console.WriteLine("ちょうどいい");
            }
            else if (weight < 120)
            {
                Console.WriteLine($"デブかも{weight - 80}kg減らしましょう");
            }
            else
            {
                Console.WriteLine("おすもうさん\n危険です");
            }
        }
    }
}