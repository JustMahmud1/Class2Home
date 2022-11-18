using System;
using System.Collections.Generic;
using System.Text;

namespace Heyvanlar
{
    class Animals
    {
        public int Id;
        public string Kind;
        public string Color;

        public Animals(int id, string kind, string color)
        {
            this.Id = id;
            this.Kind = kind;
            this.Color = color;
        }

        public Animals():this(0 , "Animal", "Animal")
        {

        }

        public void GetKind()
        {
            Console.WriteLine(this.Kind);
        }
    }
}
