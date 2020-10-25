using System;
using System.Collections.Generic;
using System.Text;

namespace java_animals
{
    class Teacher : Person, ITalkable
    {
        private int age { get; set; }

        public Teacher(int teacherAge, String name)
        {
            Name = name;
            age = teacherAge;
            
        }
        
        public String talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
