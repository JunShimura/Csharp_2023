using System;
using System.Linq;

namespace InheritanceSampleSuraSura
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("しむら", 25);
            Student[] student1 = {
                new Student("anbo", 18, "デジタルアーツ仙台",10000),
                new Student("iizawa", 19, "デジタルアーツ仙台", 10001)
            };
            Worker worker1 = new Worker("seki", 22);
            student1[0].SelfIntroduction();    //基底クラスのメンバ関数を呼び出せる
            Person.SelfIntroduction(worker1);
            ElementarySchoolStudent iwamatsu
                = new ElementarySchoolStudent("いわまつ",8, "デジタルアーツ仙台",4,2);
            //iwamatsu.SelfIntroduction();
            Member tempMemer = iwamatsu;
            tempMemer.SelfIntroduction();

            Person[] persons = new Person[] { person1, student1[0], student1[1], worker1, iwamatsu };
             foreach( Person person in persons)
            {
                person.SelfIntroduction();
            }
        }
    }
}
