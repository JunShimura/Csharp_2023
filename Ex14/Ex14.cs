namespace Ex14
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
                //一番下のけた
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から2番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から3番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から4番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;

                answer = " "+answer;

                //下から5番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から6番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から7番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から8番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;

                answer = " " + answer;

                //下から9番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から10番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から11番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から12番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;

                answer = " " + answer;

                //下から13番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から14番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から15番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;
                //下から16番目
                answer = inputNumber % 2 + answer;
                inputNumber /= 2;

                Console.WriteLine("2進数:{0}", answer);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}