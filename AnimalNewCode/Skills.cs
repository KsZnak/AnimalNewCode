using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    public abstract class Skills : Animal
    {
        public string _fly;
        public string _run;
        public string _growl;
        

        public virtual void Fly( )
        {
            _fly = " летать";
           skills = skills + _fly;

        }
        public void Run ()
        {
            _run = " бегать";
            skills = skills + _run;


        }
        public void Growl()
        {
            _growl = " рычать";
            skills = _growl + skills;
            

        }

    }
}
