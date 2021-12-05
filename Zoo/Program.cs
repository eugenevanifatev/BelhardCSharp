using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Grass grass = new Grass();
            grass.Grow();

            Zebra zebra = new Zebra();
            zebra.Name = "Igor";
            zebra.Eat(grass);

            Tiger tiger = new Tiger();
            tiger.Name = "Petr";
            tiger.Eat(zebra);
            tiger.GetVoice();
        }
    }
}
