using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattern
{
    public class AirplaneFacede
    {
        private AirplaneEngine engine;
        private AirplaneEngineNumber engNumber;
        private AirplaneLength length;
        private AirplaneMaterial material;
        private AirplaneWingspan wingspan;

        public AirplaneFacede() {
            engine = new AirplaneEngine();
            engNumber = new AirplaneEngineNumber();
            length = new AirplaneLength();
            material = new AirplaneMaterial();
            wingspan = new AirplaneWingspan();
        }

        public void createAirplane() {
            Console.WriteLine("Please set properties");
            setEngine();
            setLengthWingspan();
            setMaterial();
            Console.WriteLine("Airplane done");
            Console.WriteLine();

            printPlane();
        }

        public void setEngine() {
            Console.WriteLine("Define the number of engines: maximum 4 and must be even");
            engNumber.setNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine("Define the engine: \n a: Airbus \n b: Boing \n d: Dessault \n s: Saab \n l: lockheed : ");
            engine.setEngine(char.Parse(Console.ReadLine()));
        }

        public void setLengthWingspan() {
            Console.WriteLine("Set airplane length: (m) ");
            length.setLength(int.Parse(Console.ReadLine()));
            Console.WriteLine("Set airplane wingspan: (m) ");
            wingspan.setWingspan(int.Parse(Console.ReadLine()));
        }

        public void setMaterial() {
            Console.WriteLine("Set the material");
            material.setMaterial(Console.ReadLine());
        }

        public void printPlane() {
            Console.WriteLine("The airplane has " + engNumber.engineNro + " " + engine.engine + " engines \n" +
                "made of " + material.material + " with a length and wingspan of " + length.length + " meters and " + wingspan.wingspan +
                " meters");
        }
    }
}
