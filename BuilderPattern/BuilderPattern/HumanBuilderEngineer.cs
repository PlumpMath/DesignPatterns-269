using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HumanBuilderEngineer
    {
        public Human generate() {
            HumanBuilder builder = new HumanBuilder();

            builder.setColor("Yellow");
            builder.setGender('X');
            builder.setHeight(170);
            builder.setWeight(65);
            builder.setName("Luke");

            return builder.getResult();

        }
    }
}
