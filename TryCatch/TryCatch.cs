namespace TryCatch;

internal class TryCatch
{
    static void Main(string[] args)
    {
        Console.WriteLine("リンゴの数はいくつ？");
        int apple = int.Parse(Console.ReadLine());
        Console.WriteLine("何人で分けますか？");
        int men = int.Parse(Console.ReadLine());
        int div=0;
        int mod=0;

        try
        {
            checked
            {
                div = apple / men;
                mod = apple % men;
            }
        }
        catch (DivideByZeroException)
        {
            //Console.WriteLine("0除算が発生しました");
            div = 0;
            mod = apple;
        }
        catch (OverflowException)
        {
            Console.WriteLine("オーバーフローが発生しました");
        }
        Console.WriteLine($"ひとり{div}個で{mod}個あまります。");
        Console.WriteLine("処理終了");
    }
}