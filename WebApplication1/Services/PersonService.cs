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
}