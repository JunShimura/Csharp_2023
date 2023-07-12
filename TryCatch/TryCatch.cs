namespace TryCatch;

internal class TryCatch
{
    static void Main(string[] args)
    {
        int apple = 0;
        /*
        while (true)
        {
            Console.WriteLine("リンゴの数はいくつ？");
            string s = Console.ReadLine();
            try
            {
                apple = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"{s}: Null");
            }
            catch (FormatException)
            {
                Console.WriteLine($"{s}: Bad Format");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{s}: Overflow");
            }
            if (apple != 0)
            {
                break;
            }
        }
        */
        // tryCatch版
        while (true)
        {
            Console.WriteLine("リンゴの数はいくつ？");
            if (int.TryParse(Console.ReadLine(), out apple))
            {
                break;
            }
            Console.WriteLine("入力エラー");
        }

        Console.WriteLine("何人で分けますか？");
        int men = int.Parse(Console.ReadLine());
        int div=0;
        int mod=0;
        int mul = 0;

        try
        {
            checked
            {
                div = apple / men;
                mod = apple % men;
                mul= div*men * 7;
            }
        }
        catch (DivideByZeroException e)
        {
            //Console.WriteLine("0除算が発生しました");
            Console.WriteLine($"例外が発生しました：" + e.Message.ToString());
            div = 0;
            mod = apple;
        }
        catch (OverflowException)
        {
            Console.WriteLine("オーバーフローが発生しました,答えは正確ではありません。");
        }
        finally
        {
            Console.WriteLine($"ひとり{div}個で{mod}個あまります。\n一週間で{mul}個が必要です");
        }
        Console.WriteLine("処理終了");
    }
}