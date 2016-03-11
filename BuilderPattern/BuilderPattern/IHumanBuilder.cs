using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IHumanBuilder
    {
        void setHeight(int height);
        void setWeight(int weight);
        void setColor(string color);
        void setGender(char gender);
        void setName(string name);

        Human getResult();
    }
}
