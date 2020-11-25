using System;
using System.Collections.Generic;
using System.Text;

namespace labb2a
{
    public class Gryffindor:House
    {
        //public string HouseGhost => "Nästan Huvulöse Nick"; // => är som en "GET" behövs ingen "setter" eftersom det inte ska ändra
        //public string Mascot => "lion";
        //public string Password => "en ensam trollkarl";
        

        public Gryffindor()
        {
            HouseGhost = "Nästan Huvulöse Nick";
            Mascot = "lion";
            Password = "en ensam trollkarl";
            Members = new List<Wizard>();
            Wizard wizard = new Wizard();
            wizard.BloodStatus = "Halvblood";
            wizard.DeathEater = false;
            wizard.DumbledoresArmy = true;
            wizard.Name = "Harry potter";
            wizard.WizardWand = new Wand();
            wizard.WizardWand.Woodtype = "Furutrall";
            Members.Add(wizard);

        }


    }
}
