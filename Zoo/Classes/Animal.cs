using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal : IDisposable
    {
        public virtual string Name { get; set; }
        public virtual string Voice { get; set; }

        public void GetVoice()
        {
            Console.WriteLine(this.Voice);
        }

        public void Dispose()
        {
            Console.WriteLine($"{Name} is dead.");
            GetVoice();
        }

    }
}
