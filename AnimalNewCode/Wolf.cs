using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Wolf : Animal
    {
        public Wolf(string wname, string wcolor, int wage)
        {
            type = "Волк";
            name = wname;
            color = wcolor;
            age = wage;
            
           
        }
        public void particularspecies()
        {
            meal = "мясо";
            vois = " рычит ";
            sleep = " как все волки ";
            howl = " средней длины ";
        }

    }
}
