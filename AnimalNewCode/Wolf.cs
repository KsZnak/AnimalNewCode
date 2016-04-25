using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Wolf : Skills
    {
       
         
        public Wolf(string Name, string Color, int Age)
        {
            Type = " Волк ";
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;
            
           
        }
        public void particularspecies()
        {
            Meal = "мясо";
            Vois = " рычит ";
            Sleep = " как все волки ";
            Surface = " средней длины шерсть ";
        }

        public void Skills()
        {
            Run();
            Growl();

        }

    }
}
