using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Human
    {
        public Human() { }

        public int height { get; set; }
        public int weight { get; set; }
        public string color { get; set; }
        public char gender { get; set; }
        public string name { get; set; }

        public void print() {
            Console.WriteLine(name + " is " + height + " meters tall and weights " + weight + " kg \n"
                + " gender and color are " + gender + " and " + color);
        }
    }
}
