using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DataAccessDemo: IDataAccess
    {
        private List<Person> persons = new();

        public DataAccessDemo()
        {
            persons.Add(new Person { Id = 1, FirstName = "Waqas", LastName = "Yousuf" });
            persons.Add(new Person { Id = 2, FirstName = "John", LastName = "Doe" });
        }

        public List<Person> GetPersons()
        {
            return persons;
        }

        public Person InsetPerson(string firstName, string lastName)
        {
            Person p = new() { FirstName = firstName, LastName = lastName };
            p.Id = persons.Max(x => x.Id) + 1;
            persons.Add(p);
            return p;
        }
    }
}
