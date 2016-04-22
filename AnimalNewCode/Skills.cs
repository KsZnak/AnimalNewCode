using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    class Skills : Animal
    {
        public string fly;
        public string run;
        public string growl;
        

        public virtual void Fly( )
        {
            fly = " летать";
            skills = skills + fly;

        }
        public void Run ()
        {
            run = " бегать";
            skills = skills + run;
        }
        public void Growl()
        {
            growl = " рычать";
            skills = skills + growl;
        }

    }
}
