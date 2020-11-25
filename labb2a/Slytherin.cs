using System;
using System.Collections.Generic;
using System.Text;

namespace labb2a
{
    public class Slytherin:House
    {
        //public string HouseGhost => "Den Blodige Baronen";
        //public string Mascot => "serpent";
        //public string Password => "nattochnatt";

        public Slytherin()
        {
            HouseGhost = "Den blodige Baronen";
            Mascot = "serpent";
            Password = "nattochnatt";
        }

      

        public override bool HasCorrectPasswordFormat(string password) // override kör den här lösenordskollen ist för hus?
        {
            if (password.Length >= 8 && IsConsonant(password[0]) && IsConsonant(password[password.Length -1]))
            {
                return true;
            }
            return false;
        }   


    }
}
