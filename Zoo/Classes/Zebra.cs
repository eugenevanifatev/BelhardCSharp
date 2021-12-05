using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Zebra : Animal, IAnimalable, IHerbivore
    {
        public override string Name { get => base.Name; set => base.Name = value; }

        public Zebra()
        {
            base.Voice = "I-go-go..";
        }

        public void Eat<T>(T plant) where T : Plant 
        {
            plant.BeEaten();
        }

        
    }
}
