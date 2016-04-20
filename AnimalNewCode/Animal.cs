using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Animal
    {
        public string name, color, meal, howl, vois, sleep, type, skill;
        public int age;
        public string AnimalsInfo, AnimalParticularSpecies;
        public bool sweem, run, fly;

     public void skillsplay ()
        {
            if (sweem)
                skill = skill + "Умеет плавать";
            else skill = skill + "";
       
            if (run)
                skill = skill + "Умеет бегать";
            else skill = skill + "";

            if (fly)
                skill = skill + "умеет летать";
            else skill = skill + "";
                 
        } 

        
      



        public void Show()
        {
            AnimalsInfo = " Имя " + name + "\n" + " Цвет "  + color + "\n" +" Возраст " + age ;
            AnimalParticularSpecies = " еда " + meal + "\n" + " голос " + vois + "\n" + " спит " + sleep + "\n" + howl + "шерсть ";
            Console.WriteLine(type + "\n" + skill + "\n" + AnimalsInfo + "\n");
            Console.WriteLine(AnimalParticularSpecies + "\n");
            Console.ReadKey();
        }

        


    }

    
}
