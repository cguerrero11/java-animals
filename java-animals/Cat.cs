using System;
using System.Collections.Generic;
using System.Text;

namespace java_animals
{
    class Cat : Pet, ITalkable
    {
        int miceKilled { get; set; }
        public Cat(int mousesKilled, String name)
        {
            Name = name;

            miceKilled = mousesKilled;
        }
        public void addMouse()
        {
            miceKilled++;
        }
        public String talk()
        {
            return "Meow";
        }
        
    }
}
