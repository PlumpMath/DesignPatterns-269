using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Originator.Memento> savedStates = new List<Originator.Memento>();

            Originator originator = new Originator("A", "B");
            originator.saveMemento();
            savedStates.Add(originator.getMemento());

            originator.setStr("C", "D");
            originator.saveMemento();
            savedStates.Add(originator.getMemento());

            originator.setStr("E", "F");
            originator.saveMemento();
            savedStates.Add(originator.getMemento());

            foreach (Originator.Memento mem in savedStates) {
                Console.WriteLine(mem.getStr1() + " " + mem.getStr2());
            }

            Console.ReadKey();
        }
    }
}
