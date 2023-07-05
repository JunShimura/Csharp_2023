namespace TryCatch;

internal class TryCatch
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c;
        try
        {
            c = 
                .* int.MaxValue;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0除算が発生しました");
        }
        catch (OverflowException)
        {
            Console.WriteLine("オーバーフローが発生しました");
        }
        Console.WriteLine("処理終了");
    }
}