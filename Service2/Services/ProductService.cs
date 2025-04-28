using Microsoft.EntityFrameworkCore;
using Service2.Entities;
using Service2.Utils;

namespace Service2.Services;

public class ProductService
{
    private NDBcontext _ndBcontext;

    public ProductService(NDBcontext ndBcontext)
    {
        _ndBcontext = ndBcontext; 
    }

    public List<Product> getAll()
    {
        return _ndBcontext.Products.ToList(); 
    }
    
}