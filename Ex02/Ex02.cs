namespace Ex02
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("幅(m)を入力してください"); // 文字列を出す
            var width = double.Parse(Console.ReadLine());   // 文字列を入力しwidthに変換し代入
            Console.WriteLine("奥行(m)を入力してください"); // 文字列を出す
            var depth = double.Parse(Console.ReadLine());   // 文字列を入力しdepthに変換し代入
            Console.WriteLine("高さ(m)を入力してください"); // 文字列を出す
            var height = double.Parse(Console.ReadLine());   // 文字列を入力しheightに変換し代入
            Console.WriteLine($"表面積は{(width * height + width * depth + height * depth) * 2}㎡、体積は{width * depth * height}立方ｍ");
        }
    }
}
