using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_101 {
    public class Car : Verhicle {

        public Car(string Band, string Model, string Color, int EngineSize)
        {
            band = Band;
            model = Model;
            color = Color;
            engineSize = EngineSize;
            verhicleCount++;
            Console.WriteLine(verhicleCount);
        }
        public void Start()
        {
            Console.WriteLine(band+" "+model+" ("+color+") enginesize "+engineSize);
        }
    }
}
