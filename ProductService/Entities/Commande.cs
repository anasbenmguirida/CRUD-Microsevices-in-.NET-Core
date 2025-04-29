using System.Runtime.InteropServices.JavaScript;

namespace Service2.Entities;

public class Commande
{
    public int Id { get; set; }
    public List<int> productIds;
    public int userId;
    public DateOnly dateCommande; 
}