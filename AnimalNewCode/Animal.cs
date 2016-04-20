using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Animal
    {
        public string name, color, meal, howl, vois, sleep, type, skilsstring;
        public int age;
        public string AnimalsInfo, AnimalParticularSpecies;

        public void sweem(string skilsstring)
        {
            skilsstring = skilsstring + "Может плавать";
        }
        public void run (string skilsstring)
        {
            skilsstring = skilsstring + "Может бегать";
        }



        public void Show()
        {
            AnimalsInfo = " Имя " + name + "\n" + " Цвет "  + color + "\n" +" Возраст " + age ;
            AnimalParticularSpecies = " еда " + meal + "\n" + " голос " + vois + "\n" + " спит " + sleep + "\n" + howl + "шерсть ";
            Console.WriteLine(type + "\n" + skilsstring + "\n" + AnimalsInfo + "\n");
            Console.WriteLine(AnimalParticularSpecies + "\n");
            Console.ReadKey();
        }

        


    }

    
}
