using System.Collections;
using System.Linq;
using System.Drawing;

namespace Ex17_sortVariation
{
    internal class Ex17_sortVariation
    {
        //設定
        const int tableSize = 100000;
        const int randomRangeMin = int.MinValue;
        const int randomRangeMax = int.MaxValue;

        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table0 = new int[tableSize];
            int[] table1 = new int[tableSize];
            int[] table2 = new int[tableSize];
            int[] table3 = new int[tableSize];
            int[] table4 = new int[tableSize];

            for (int i = 0; i < table0.Length; i++)
            {
                table0[i]
                    = table1[i]
                    = table2[i]
                    = table3[i] = table4[i]
                    = random.Next(randomRangeMin, randomRangeMax);  //Randomを使う場合
                  //= table0.Length - i;
                //Console.WriteLine($"table[{i}]={table[i]}");
            }

            //選択ソート
            Console.WriteLine("選択ソート開始");
            sw.Reset();
            sw.Start(); // 時間計測
            for (var fixId = 0; fixId < table0.Length - 1; fixId++)
            {
                var maxId = fixId;  //仮の最大値の入る索引
                //最大値の在る索引をmaxIdに求める
                for (int i = fixId + 1; i < table0.Length; i++)
                {
                    if (table0[maxId] < table0[i])
                    {   //もっと大きい値があった場合、最大値を更新
                        maxId = i;
                    }
                }
                //最大値を固定したいIDのデータと交換
                if (maxId != fixId)
                {
                    var temp = table0[maxId];
                    table0[maxId] = table0[fixId];
                    table0[fixId] = temp;
                }
            }
            sw.Stop();  // 時間計測終了
            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");


            //バブルソート
            Console.WriteLine("バブルソート開始");
            sw.Reset();
            sw.Start(); // 時間計測
            for (var fixId = table1.Length - 1; fixId > 0; fixId--)
            {
                bool isSwaped = false;
                for (int i = 0; i < fixId; i++)
                {
                    if (table1[i] < table1[i + 1])
                    {   // i番目と(i+1)番目を交換
                        var temp = table1[i + 1];
                        table1[i + 1] = table1[i];
                        table1[i] = temp;
                        isSwaped = true;
                    }
                }
                if (!isSwaped)
                {
                    break;
                }
            }
            sw.Stop();  // 時間計測終了

            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");
            
            // 組み込まれたSort
            Console.WriteLine(".Sort,Reverse開始");
            sw.Reset();
            sw.Start(); // 時間計測
            Array.Sort(table2);
            Array.Reverse(table2);
            sw.Stop();  // 時間計測終了

            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");

            // 組み込まれたSort
            Console.WriteLine(".Sort開始");
            // Instantiate the reverse comparer.
            IComparer revComparer = new ReverseComparer();
            sw.Reset();
            sw.Start(); // 時間計測
            Array.Sort(table3,revComparer);
            sw.Stop();  // 時間計測終了

            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");

            // 組み込まれたLinq
            Console.WriteLine("OrderBy開始");
            IEnumerable<int> testOrderBy;
            sw.Reset();
            sw.Start(); // 時間計測
            testOrderBy= table4.OrderBy(o => o).Reverse();
            //Console.WriteLine($"first={testOrderBy.First().ToString()}");
            Console.WriteLine($"last={testOrderBy.Last().ToString()}");
            sw.Stop();  // 時間計測終了
            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
    public class ReverseComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }



}