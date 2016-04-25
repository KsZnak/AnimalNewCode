using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
   public  abstract class Animal 
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public string Meal { get; set; }
        public string Surface { get; set; }
        public string Vois { get; set; }
        public string Sleep { get; set; }
        public string Type { get; set; }
        public string Podtype { get; set; }
        public string SkillsString { get; set; }
        public int Age {get; set; }
        public string AnimalsInfo, AnimalParticularSpecies, Animalskills;
        

       

        

        public void Show()
        {
            
            AnimalsInfo = " Имя " + Name + "\n" + " Цвет "  + Color + "\n" +" Возраст " + Age ;
            AnimalParticularSpecies = " еда " + Meal + "\n" + " голос " + Vois + "\n" + " спит " + Sleep + "\n" + Surface ;
            Animalskills = "Умения "  + SkillsString;
            Console.WriteLine(Type + Podtype  + "\n" + AnimalsInfo + "\n");
            Console.WriteLine( Animalskills + "\n" +  AnimalParticularSpecies + "\n" ); 
            Console.ReadKey();
        }

        


    }

    
}
