namespace Challenge2023_02
{
    internal class Program
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

            //最頻値を求める
            int[] frequency = new int[table.Length];
            for (var i = 1; i < table.Length; i++)
            {
                frequency[i] = 0;
                for (var j = 0; j < table.Length; j++)
                {
                    if (table[i] == table[j])
                    {
                        frequency[i]++;
                    }
                }
            }
            var max = 0;
            for (var i = 0; i < frequency.Length; ++i)
            {
                if (max < frequency[i])
                {   //もっと大きい値があった場合、最大値を更新
                    max = frequency[i];
                }
            }
            int[] maxFreqValue = new int[table.Length];
            int maxFreqValueID = 0;
            for (var i = 0; i < frequency.Length; ++i)
            {
                if (frequency[i] == max)
                {   //最大値の頻度の数値を出力 table[i]
                    bool found = false;
                    for(var j = 0; j < maxFreqValueID; j++)
                    {
                        if (maxFreqValue[j] == table[i])
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        maxFreqValue[maxFreqValueID++] = table[i];
                    }
                }
            }
            var message = "最頻値=";
            for (var i = 0; i < maxFreqValueID; i++)
            {
                {   //最大値の頻度の数値を出力
                    message += $"{maxFreqValue[i]} ";
                }
            }
            Console.WriteLine(message);
        }
    }
}