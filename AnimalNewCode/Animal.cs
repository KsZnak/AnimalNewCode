using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    public abstract class Animal 
    {
        public string name, color, meal, howl, vois, sleep, type, skills;
        public int age;
        public string AnimalsInfo, AnimalParticularSpecies, Animalskills;
        

       

        

        public void Show()
        {
            AnimalsInfo = " Имя " + name + "\n" + " Цвет "  + color + "\n" +" Возраст " + age ;
            AnimalParticularSpecies = " еда " + meal + "\n" + " голос " + vois + "\n" + " спит " + sleep + "\n" + howl + "шерсть ";
            Animalskills = "Умения "  + skills;
            Console.WriteLine(type  + "\n" + AnimalsInfo + "\n");
            Console.WriteLine( Animalskills + "\n" +  AnimalParticularSpecies + "\n" ); 
            Console.ReadKey();
        }

        


    }

    
}
