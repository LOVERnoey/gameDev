using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_101 {
    public class Plane : Verhicle {

        public Plane() 
        {

        }
        public Plane(string Band, string Model, string Color, int EngineSize)
        {
            band = Band;
            model = Model;
            color = Color;
            engineSize = EngineSize;
            Console.WriteLine(verhicleCount);
        }
    }
}
