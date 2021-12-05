using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Plant
    {
        public int Weight { get; set; }

        public void Grow()
        {
            Weight++;
        }

        public void BeEaten()
        {
            Weight--;
        }
    }
}
