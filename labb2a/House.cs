using System;
using System.Collections.Generic;
using System.Text;

namespace labb2a
{
    public abstract class House
    {
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public List<Wizard> Members { get; set; }

        public bool IsVowel(char c)
        {
            string vowle = "aeiouyåäöAEIOUYÅÄÖ";
            
            foreach (char v in vowle)
            {
                if (c == v)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsConsonant(char c)
        {
            string consonant = "bcdfghjklmnpqrstvzxBCDFGHJKLMNPQRSTVZX"; // testade denna istället for en foreach loop
            return consonant.Contains(c);
        }

        public virtual bool IsPasswordCorrect(string password)
        {
            return password == Password;
        }

        public virtual void SetPassword(string password)
        {
            if (HasCorrectPasswordFormat(password)) 
            {
                Password = password;
            }
                
            
        }

        public virtual bool HasCorrectPasswordFormat(string password)
        {
            if (password.Length >= 5 && IsVowel(password[0]) && IsConsonant(password[password.Length - 1]))
            {
                return true;

            }
            return false;
        }



    }

}
