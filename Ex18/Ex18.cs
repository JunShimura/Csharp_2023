using System.Text;

namespace Ex18
{
    internal class Ex18
    {
        static void Main(string[] args)
        {
            HelloWorldEnglish();
            HelloWorldJapanese();
            HelloWorldBelorussiya();
        }

        static void HelloWorldEnglish()
        {
            Console.WriteLine("Hello World!");
        }
        static void HelloWorldJapanese()
        {
            Console.WriteLine("こんにちは世界!");
        }
        static void HelloWorldBelorussiya()
        {
            Console.WriteLine("Прывітанне Сусвет!");
        }
        static void HelloWorldKorean()
        {
            Console.OutputEncoding = Encoding.UTF32;
            Console.WriteLine("안녕하세요!");
        }
    }
}