namespace Ex14_ex2
{
    class ConvertBinary
    {
        static void Main(string[] args)
        {
            int inputNumber;
            Console.WriteLine("数を入力:");
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 65535)
            {
                string answer = "";
                for (var i = 0; i < 4; i++)
                {
                    for (var j = 0; j < 4; i++)
                    {
                        answer = inputNumber % 2 + answer;
                        inputNumber /= 2;
                    }
                    answer = " " + answer;
                }
                Console.WriteLine("2進数:{0}", answer);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}