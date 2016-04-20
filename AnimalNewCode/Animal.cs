using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Animal
    {
        public string name, color, meal, howl, vois, sleep;
        public int age { get; set; }
        public string Animalsinfo, Animalfeatures;
        

        

        public void Show()
        {
            Animalsinfo = " Имя " + name + " Цвет " + color + " Возраст " + age ;
            Animalfeatures = " еда " + meal + " голос " + vois + " спит ";
            Console.WriteLine(Animalsinfo );
            Console.WriteLine(Animalfeatures);
            Console.ReadKey();
        }


    }

    
}
