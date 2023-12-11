using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_101 {
    public class Verhicle {
        public static int verhicleCount;

        public string band;
        public string model;
        public string color;
        public int engineSize;

        public Verhicle()
        {
        }
        public Verhicle(string Band, string Model, string Color, int EngineSize)
        {
            band = Band;
            model = Model;
            color = Color;
            engineSize = EngineSize;
        }
        public static void PrintVC() 
        {
            Console.WriteLine(verhicleCount);
        }
    }
}
