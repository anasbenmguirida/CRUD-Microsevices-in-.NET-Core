using Microsoft.AspNetCore.Mvc;

using Service2.Entities;
using Service2.Services;

namespace Service2.Controllers;

[ApiController]
[Route("api/")]
public class ProductController
{
    private ProductService _productService;
    private UserClient _userClient; 

    public ProductController(ProductService productService , UserClient userClient)
    {
        _productService = productService;
        _userClient = userClient; 
    }

    [HttpGet("all-products")]
    public List<Product> getAll()
    {
        return _productService.getAll(); 
    }
    
    [HttpGet("users")]
    public async Task<object> GetUserNames()
    {
        var result = await _userClient.GetUserNames();
        return result; 
    }
    

}