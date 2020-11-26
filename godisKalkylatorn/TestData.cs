using System;
using System.Collections.Generic;
using System.Text;

namespace godisKalkylatorn
{
    public class TestData
    {
        public List<Person> People { get; set; }
        

        public TestData()
        {
            Person person = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person.Firstname = "ahmed";
            person.LastName = "muhammed";
            person.Age = 12;
            

            person2.Firstname = "mawran";
            person2.LastName = "ftt";
            person2.Age = 42;
            

            person3.Firstname = "kuken";
            person3.LastName = "asdfff";
            person3.Age = 23;
            

            People = new List<Person>();
            People.Add(person);
            People.Add(person2);
            People.Add(person3);
            

        }







    }
}
