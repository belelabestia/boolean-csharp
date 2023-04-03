using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class PersonDb
    {
        public List<Person> people = new();

        public void Insert(Person person)
        {
            if (person.Name is "") throw new ArgumentException("Name cannot be empty.");
            if (person.Age < 0) throw new ArgumentException("Age cannot be negative.");

            people.Add(person);
        }

        public List<Person> FilterPeopleByName(string name)
        {
            return people.Where(p => p.Name == name).ToList();
        }
    }
}
