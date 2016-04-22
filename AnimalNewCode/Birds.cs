using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    public abstract class Birds : Skills
    {
        public  void Skills()
        {
           
            surface = "перья";
            type = "Птица";
            return;
            
        }
     
        public class Pinguin: Birds
        {
            public Pinguin (string _PinguinName, string _PinguinColor, int _PinguinAge)
            {
                podtype = type + " Пингвин ";
                name = _PinguinName;
                color = _PinguinColor;
                age = _PinguinAge;
                Sweem();
               

            }
            public void Particularspecies()
            {


                meal = "рыба ";
                vois = " - ";
                sleep = " 10 часов ";
               
            }



        }

    }
}
