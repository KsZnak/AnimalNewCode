using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Bears : Skills
    {
        
        
        public Bears ( string _bear_name, string _bear_color , int _bear_age) 
        {

            
            type = " Медведь ";   
            name =  _bear_name;
            color =_bear_color;
            age = _bear_age;
            
           
        }

        public void Particularspecies( )
        {
            

            meal = "рыба и мёд";
            vois = " рычит ";
            sleep = " всю зиму ";
            howl = " средней длины ";
        }

       public void Skills ()
        {
            Run();
            Growl();
          
        }






    }

}


