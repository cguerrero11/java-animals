using System;
using System.Collections.Generic;
using System.Text;

namespace java_animals
{
    class Dog : Pet, ITalkable
    {
        Boolean isFriendly;
        public Dog(Boolean freindly, String name)
        {
            Name = name;
            isFriendly = freindly;
        }
        public String talk()
        {
            return "Bark";
        }
    }
}
