using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class Student:Member
    {
        private int Id;  // 学籍番号
        public Student(string name, int age = 0, string organization = null, int Id=0 ):base(name,age,organization)
        {
            this.Id = Id;
        }
        new public void  SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"学籍番号は{Id}です。");
        }
    }
}
