namespace Ex14_Katsumata;
public class Test
{
    static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            Console.WriteLine("入力エラー");
            return;
        }
        else if (!(inputNumber >= 0 && inputNumber <= 65535))
        {
            Console.WriteLine("入力エラー");
            return;
        }
        else
        {
            if (!(inputNumber >= 0 && inputNumber <= 65535))
            {
                Console.WriteLine("入力エラー");
                return;
            }

            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                string j = "";
                for (int k = 0; k < 4; k++)
                {
                    j = inputNumber % 2 + j;
                    inputNumber /= 2;
                }
                answer = j + $" {answer}";
            }
            Console.Write($"2進数 : {answer}");
        }
    }
}