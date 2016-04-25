using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNewCode
{
    public abstract class Skills : Animal
    {
        string _fly;
        string _run;
        string _growl;
        string _sweem;
        

        public virtual void Fly( )
        {
            _fly = " летать";
            SkillsString = SkillsString + _fly;

        }
        public void Run ()
        {
            _run = " бегать";
            SkillsString = SkillsString + _run;


        }
        public void Growl()
        {
            _growl = " рычать";
            SkillsString = SkillsString  + _growl;
            

        }
        public  void   Sweem()
        {
            _sweem = "плавать";
            SkillsString = SkillsString + _sweem;
            
        }
           

    }
}
