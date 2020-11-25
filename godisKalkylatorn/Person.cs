using System;
using System.Collections.Generic;
using System.Text;

namespace godisKalkylatorn
{
    public class Person
    {
        public int Age { get; set; }
        public int CandyAmount { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }



        public override string ToString()
        {
            return $"{Firstname} {LastName} {Age}";
        }


    }
    


}
