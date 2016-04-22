using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    public abstract class Animal 
    {
        public string name, color, meal, surface, vois, sleep, type, podtype, skills;
        public int age;
        public string AnimalsInfo, AnimalParticularSpecies, Animalskills;
        

       

        

        public void Show()
        {
            AnimalsInfo = " Имя " + name + "\n" + " Цвет "  + color + "\n" +" Возраст " + age ;
            AnimalParticularSpecies = " еда " + meal + "\n" + " голос " + vois + "\n" + " спит " + sleep + "\n" + surface ;
            Animalskills = "Умения "  + skills;
            Console.WriteLine(type + podtype  + "\n" + AnimalsInfo + "\n");
            Console.WriteLine( Animalskills + "\n" +  AnimalParticularSpecies + "\n" ); 
            Console.ReadKey();
        }

        


    }

    
}
