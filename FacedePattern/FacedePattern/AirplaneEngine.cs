using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattern
{
    public class AirplaneEngine
    {
        public string engine{ get; set; }

        public void setEngine(char c) {
            switch (c) {
                case 'a':
                case 'A': engine = "Airbus"; break;
                case 'b':
                case 'B': engine = "Boing"; break;
                case 'd':
                case 'D': engine = "Dessault"; break;
                case 's':
                case 'S': engine = "Saab"; break;
                case 'l':
                case 'L': engine = "Lockheed"; break;
                default: engine = "Engine not set yet"; break;
            }
        }
    }
}
