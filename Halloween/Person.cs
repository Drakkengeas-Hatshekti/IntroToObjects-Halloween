using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Person
    {
        //Declaring properties for my Person object
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(int age, string name, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
