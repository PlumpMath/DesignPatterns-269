using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HumanBuilder : IHumanBuilder
    {
        private Human human;

        public HumanBuilder() {
            human = new Human();
        }

        public Human getResult()
        {
            return human;
        }

        public void setColor(string color)
        {
            this.human.color = color;
        }

        public void setGender(char gender)
        {
            this.human.gender = gender;
        }

        public void setHeight(int height)
        {
            this.human.height = height;
        }

        public void setName(string name)
        {
            this.human.name = name;
        }

        public void setWeight(int weight)
        {
            this.human.weight = weight;
        }
    }
}
