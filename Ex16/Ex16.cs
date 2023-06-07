namespace Ex16
{
    internal class Ex16
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

            //最大値,最小値を求める
            var max = table[0];
            var min = table[0];
            var sum = table[0];
            for (var i = 1; i < table.Length; i++)
            {
                if (max < table[i])
                {   //もっと大きい値があった場合、最大値を更新
                    max = table[i];
                }
                else if (min > table[i])
                {   //もっと小さい値があった場合、最小値を更新
                    min = table[i];
                }
                sum += table[i];
            }
            Console.WriteLine($"最大値＝{max}\n最小値={min}");
            Console.WriteLine($"平均={(double)sum / table.Length}");
            //中央値を求める
            //tableを降順でソート
            for (var fixId = 0; fixId < table.Length - 1; fixId++)
            {
                var maxId = fixId;  //仮の最大値の入る索引
                //最大値の在る索引をmaxIdに求める
                for (int i = fixId + 1; i < table.Length; i++)
                {
                    if (table[maxId] < table[i])
                    {   //もっと大きい値があった場合、最大値を更新
                        maxId = i;
                    }
                }
                //最大値を固定したいIDのデータと交換
                if (maxId != fixId)
                {
                    var temp = table[maxId];
                    table[maxId] = table[fixId];
                    table[fixId] = temp;
                }
            }
            if(table.Length%2 == 1)
            {
                Console.WriteLine($"中央値={table[(table.Length - 1) / 2]}");
            }
            else
            {
                Console.WriteLine($"中央値={(double)(table[(table.Length-1) / 2]+ table[table.Length / 2])/2}");
            }
        }
    }

}