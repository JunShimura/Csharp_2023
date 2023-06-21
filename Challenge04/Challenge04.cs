using System.Collections;
using System.Linq;


namespace Challenge04
{
    internal class Challenge04
    {
        static char[] t = new char[] { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
        static List<List<char>> minoPattern = new List<List<char>>();

        static void Main(string[] args)
        {
            minoPattern = GetCombination<char>(new List<char>(t));
        }


        static List<List<T>> GetCombination<T>(List<T> source)
        {
            if (source.Count > 1)
            {
                List<List<T>> resultList = new List<List<T>>();
                for (var i = 0; i < source.Count; i++)
                {
                    for(var j=0;j<source.Count-1; j++)
                    {
                        List<T> subList = new List<T>();
                        subList.Add(source[i]);
                        resultList.Add(subList);
                    }
                    List<T> orderList= new List<T>(source);
                    orderList.Remove(source[i]);
                    List<List<T>> subResult = GetCombination<T>(orderList);


                }
            }
            else
            {
                List<T> list = new List<T>();
                list.Add(source[0]);
                List<List<T>> result = new List<List<T>>();
                result.Add(list);
                return result;
            }
            return null;
        }
    }
}