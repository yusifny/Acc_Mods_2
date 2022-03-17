using System;
using Acc_Mods_2.Models;

namespace Acc_Mods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.name = "Yusif";
            Console.WriteLine(stu1.name);
            stu1.surname = "Nazarbayov";
            Console.WriteLine(stu1.surname);
            stu1.point = 99;
            Console.WriteLine(stu1.point);
        }
    }
}

