using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Tiger : Animal, IAnimalable
    {
        public override string Name { get => base.Name; set => base.Name = value; }

        public Tiger()
        {
            base.Voice = "R-r-r-r-r-r...";
        }

        public void Eat<T>(T animal) where T : Animal
        {
            Console.WriteLine($"Tiger {Name} ate {animal.Name}");
            animal.Dispose();
        }
    }
}
