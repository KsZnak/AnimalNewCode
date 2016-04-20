using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Bears : Animal
    {
        
        
        public Bears ( string bear_name, string bear_color , int bear_age) 
        {
            
            
            type = " Медведь ";   
            name = bear_name;
            color = bear_color;
            age = bear_age;
            
           
        }

        public void particularspecies( )
        {
            Animal skils = new Animal();
            skils.sweem(skilsstring);
            skils.run(skilsstring);
            

            meal = "рыба и мёд";
            vois = " рычит ";
            sleep = " всю зиму ";
            howl = " средней длины ";

            
        }


        
    }

}


