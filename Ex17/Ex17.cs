namespace Ex17
{
    internal class Ex17
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
            for (var i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"table[{i}]={table[i]}");
            }
        }
    }
}