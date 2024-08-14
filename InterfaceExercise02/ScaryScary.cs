using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise02
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }
        private readonly int scaryThingCount;
        public string ScaryThingIHave { get { return scaryThingCount + " spiders"; } }
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
        }

    }
}
