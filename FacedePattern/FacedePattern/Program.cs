using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            AirplaneFacede facede = new AirplaneFacede();
            facede.createAirplane();

            Console.ReadKey();
        }
    }
}
