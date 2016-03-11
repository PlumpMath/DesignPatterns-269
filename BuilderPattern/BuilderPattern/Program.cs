using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanBuilderEngineer engineer = new HumanBuilderEngineer();
            Human human = engineer.generate();
            human.print();

            Console.ReadKey();
        }
    }
}
