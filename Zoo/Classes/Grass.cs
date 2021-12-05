using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Grass : Plant, IPlantable
    {
        public Grass()
        {
            base.Weight = 0;
        }
    }
}
