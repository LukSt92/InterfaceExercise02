using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
/*            IScaryClown iScaryClownReference = (IScaryClown)fingersTheClown;
            iScaryClownReference.ScareLittleChildren();*/
            // or
            if (fingersTheClown is IScaryClown iScaryClown)
                iScaryClown.ScareAdults();            
        }
    }
}
