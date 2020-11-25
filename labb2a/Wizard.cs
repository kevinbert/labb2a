using System;
using System.Collections.Generic;
using System.Text;

namespace labb2a
{
    public class Wizard
    {
        //public string Name => "Harry Potter";
        //public string BloodStatus => "Halvblod";
        //public bool DeathEater => false;
        //public bool DumbledoresArmy => true;

        public string Name { get; set; }
        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public Wand WizardWand { get; set;}

        public override string ToString()
        {
            return $"{Name} {BloodStatus} {DeathEater} {DumbledoresArmy}";
        }

    }   

}
