﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Wolf : Animal
    {
        public Wolf(string wolf_name, string wolf_color, int wolf_age)
        {
            type = " Волк ";
            name = wolf_name;
            color = wolf_color;
            age = wolf_age;
            
           
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
