using System;
namespace Ex19;
class EX19_hint
{
    static void Main(string[] args)
    {
        //string s1 = Console.ReadLine();
        //string s2 = Praise(s1);
        //Console.WriteLine(s2);
        Console.WriteLine(Praise(InputString("名前を入力：")));
    }
    static string Praise(string s)
    {
        s = $"{s}さんかっこいい！";
        return s;
    }

    private static string InputString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
}

