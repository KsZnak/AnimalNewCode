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
           
            Surface = "перья";
            Type = "Птица";
           
            
        }
     
        public class Pinguin: Birds
        {
            public Pinguin (string Name, string Color, int Age)
            {
                Podtype = Type  + " Пингвин ";
                this.Name = Name;
                this.Color = Color;
                this.Age = Age;


            }
            public void Particularspecies()
            {
                Meal = "рыба ";
                Vois = " - ";
                Sleep = " 10 часов ";
               
            }





        }

    }
}
