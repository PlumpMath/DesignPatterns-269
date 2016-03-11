using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        public string str1 { get; set; }
        public string str2 { get; set; }
        private Memento memento;

        public Originator(string str1, string str2) {
            this.str1 = str1;
            this.str2 = str2;
        }

        public void setStr(string str1, string str2) {
            this.str1 = str1;
            this.str2 = str2;
        }

        public void saveMemento() {
            this.memento = new Memento(str1, str2);
        }

        public Memento getMemento() {
            return memento;
        }

        public class Memento
        {
            public readonly string str1;
            public readonly string str2;

            public Memento(string str1, string str2)
            {
                this.str1 = str1;
                this.str2 = str2;
            }

            public string getStr1() { return str1; }
            public string getStr2() { return str2; }
        }
    }
}
