using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Person
{
    [Key]
    public int Id { set; get;  }
    public string Name { set; get;  }
    public string City { set; get;  }
}