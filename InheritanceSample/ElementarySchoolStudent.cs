using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class ElementarySchoolStudent:Student
    {
        int grade;
        public ElementarySchoolStudent(string name, int age = 0,string organization=null, int Id = 0,int grade=1) 
            :base(name, age,organization, Id)
        {
            this.grade = grade;
        }
        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"今、{grade}年生です。");
        }
    }
}
