using System;
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
            Bears Teddy = new Bears(" Teddy ", " Broun ",  10 );
            Teddy.features(" рыба и мёд ", " громкий " , " всю зиму ");

            Teddy.Show();

            

            Wolf Seryj = new Wolf(" Серый ", " Серый ", 8);
            

            Seryj.Show();

           
        }
    }
}
