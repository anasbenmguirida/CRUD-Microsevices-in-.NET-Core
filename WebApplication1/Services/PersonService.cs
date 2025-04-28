using WebApplication1.Model;
using WebApplication1.Utils;

namespace WebApplication1.Services;

public class PersonService
{
    private readonly MyDbContext _myDbContext; 
    // dima kan injectew f constructeur 
    public PersonService(MyDbContext myDbContext)
    {
        _myDbContext = myDbContext; 
    }
    public async Task<Person> ajouterPersonneAsync(Person personne)
    {
        _myDbContext.Persons.Add(personne);
        await _myDbContext.SaveChangesAsync();
        return personne;
    }

    public async Task<List<Person>> getPersons()
    {
         List<Person> persons =  _myDbContext.Persons.ToList();
         return persons; 
    }

    public List<Person> getAll()
    {
        return _myDbContext.Persons.ToList(); 
    }
    public async Task<string> DeletePerson(int id)
    {
        Person optionalPerson = await _myDbContext.Persons.FindAsync(id);
        if (optionalPerson != null)
        {
            _myDbContext.Remove(optionalPerson);
            await _myDbContext.SaveChangesAsync(); // <-- You must save the changes
            return "deleted";
        }

        return "not found";
    }

}