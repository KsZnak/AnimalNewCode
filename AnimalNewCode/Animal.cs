using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Animal
    {
        public string name, color, meal, howl, vois, sleep, type;
        public int age { get; set; }
        public string AnimalsInfo, AnimalParticularSpecies;
        

        

        public void Show()
        {
            AnimalsInfo = " Имя " + name + "\n" + " Цвет "  + color + "\n" +" Возраст " + age ;
            AnimalParticularSpecies = " еда " + meal + "\n" + " голос " + vois + "\n" + " спит " + sleep + "\n" + howl + "шерсть ";
            Console.WriteLine(type +  "\n" + AnimalsInfo + "\n");
            Console.WriteLine(AnimalParticularSpecies + "\n");
            Console.ReadKey();
        }



    }

    
}
