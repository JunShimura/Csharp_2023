using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class Person
    {
        protected string name;
        protected int age;
        public Person(string name,int age=0)
        {
            this.name = name;
            this.age = age;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"私の名前は{name}です、年齢は{age}です。");
        }
        static public void SelfIntroduction(Person p)
        {
            Console.WriteLine($"私の名前は{p.name}です、年齢は{p.age}です。");
        }
    }
}
