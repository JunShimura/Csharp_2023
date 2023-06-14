namespace Ex17_ex2
{
    internal class Ex17_ex2
    {
        const int tableSize = 10;
        static void Main(string[] args)
        {
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"数値を入力：{i + 1}個目：");
                if (!int.TryParse(Console.ReadLine(), out table[i]))
                {
                    Console.WriteLine("入力エラー");
                    return;
                }
            }
            // バブルソート
            for (var fixId = table.Length - 1; fixId > 0; fixId--)
            {
                bool isSwaped = false;
                for (int i = 0; i < fixId; i++)
                {
                    if (table[i] < table[i + 1])
                    {   // i番目と(i+1)番目を交換
                        var temp = table[i + 1];
                        table[i + 1] = table[i];
                        table[i] = temp;
                        isSwaped = true;
                    }
                }
                if (!isSwaped) {
                    break;
                }
            }
            //結果出力
            for (var i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"table[{i}]={table[i]}");
            }
        }
    }
}