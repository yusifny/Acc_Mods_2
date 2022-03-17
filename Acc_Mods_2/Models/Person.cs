using System;
using System.Collections.Generic;
using System.Text;

namespace Acc_Mods_2.Models
{
    internal class Person
    {
        private string Name;
        private string SurName;
        private int Age;

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    Name = value;
                    Console.WriteLine(UpperLetter(name));
                }
                else
                {
                    Console.WriteLine("Name length type min 3 max 30");
                }
                if (UpperLetter(name) == false)
                {
                    Console.WriteLine("Name start big letter ");
                    return;
                }
            }
        }

        public string surname
        {
            get
            {
                return SurName;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 35)
                {
                    SurName = value;
                    Console.WriteLine(UpperLetter(SurName));
                }
                else
                {
                    Console.WriteLine("Surname length type min 3 max 35");
                }
                if (UpperLetter(SurName) == false)
                {
                    Console.WriteLine("Surname start big letter ");
                    return;
                }

            }
        }


        public Person()
        {

        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        private bool UpperLetter(string Name)
        {
            foreach (char upper in Name)
            {
                if (char.IsUpper(upper))
                    return true;
            }
            return false;
        }

    }
}