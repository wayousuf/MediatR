using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<Person> GetPersons();
        Person InsetPerson(string firstName, string lastName);
    }
}