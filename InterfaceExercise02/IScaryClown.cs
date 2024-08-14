using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise02
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave {  get; }
        void ScareLittleChildren();
        void ScareAdults()
        {
            Console.WriteLine($@"I am an ancient evil that will haunt your dreams.
    Behold my terryfying necklace with {random.Next(4, 10)} of my last victim's fingers.

    Oh. also. before I forget...");
            ScareLittleChildren();
        }
    }
}
