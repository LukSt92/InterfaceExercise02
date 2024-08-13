using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise02
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave) 
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}.");
        }
    }
}
