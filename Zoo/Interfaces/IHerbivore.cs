using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Interfaces
{
    interface IHerbivore
    {
        public void Eat<T>(T plant) where T : Plant;
    }
}
