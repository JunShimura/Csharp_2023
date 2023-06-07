namespace Ex14_ex3
{
    class Ex14_ex3
    {
        static void Main(string[] args)
        {
            int inputNumber;
            Console.WriteLine("数を入力:");
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 65535)
            {
                Console.WriteLine($"2進数："
                    + $"{(inputNumber >> 15) % 2}"
                    + $"{(inputNumber >> 14) % 2}"
                    + $"{(inputNumber >> 13) % 2}"
                    + $"{(inputNumber >> 12) % 2}"
                    + $" {(inputNumber >> 11) % 2}"
                    + $"{(inputNumber >> 10) % 2}"
                    + $"{(inputNumber >> 9) % 2}"
                    + $"{(inputNumber >> 8) % 2}"
                    + $" {(inputNumber >> 7) % 2}"
                    + $"{(inputNumber >> 6) % 2}"
                    + $"{(inputNumber >> 5) % 2}"
                    + $"{(inputNumber >> 4) % 2}"
                    + $" {(inputNumber >> 3) % 2}"
                    + $"{(inputNumber >> 2) % 2}"
                    + $"{(inputNumber >> 1) % 2}"
                    + $"{(inputNumber >> 0) % 2}"
                    );
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}