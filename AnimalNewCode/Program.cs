﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Bears Teddy = new Bears( "Тэдди ", " Коричневый ",  10 );
            Teddy.particularspecies();
           
            Teddy.Show();

            Bears Misha = new Bears( "Миша ", "Белый ", 6);
            Misha.particularspecies();
            Misha.Show();

            
            Wolf Seryj = new Wolf(" Серый ", " Серый ", 8);
            Seryj.particularspecies();
            Seryj.Show();
            
           
        }
    }
}
