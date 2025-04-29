using System.ComponentModel.DataAnnotations;

namespace Service2.Entities;

public class Product
{
    [Key]
    public int Id { get; set;  }
    public string productName { get; set;  }
    public double price { get; set;  }
}