using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Bears : Skills
    {


        public Bears(string Name, string Color, int Age)
        {
            Type = " Медведь ";
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;


        }

        public void Particularspecies( )
        {
            

            Meal = "рыба и мёд";
            Vois = " рычит ";
            Sleep = " всю зиму ";
            Surface = " средней длины шерсть";
        }

       public void Skills ()
        {
            Run();
            Growl();
           
          
        }






    }

}


