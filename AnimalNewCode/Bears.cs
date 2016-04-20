using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Bears : Animal
    {


        public Bears(string bear_name, string bear_color, int bear_age)
        {
            name = bear_name;
            color = bear_color;
            age = bear_age;
           
        }

        public void features( string bear_meal, string bear_vois, string bear_sleep)
        {
            meal = bear_meal;
            vois = bear_vois;
            sleep = bear_sleep; 
        }


        
    }

}


