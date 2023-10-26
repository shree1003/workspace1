using Microsoft.AspNetCore.Mvc;
using ProdMvc.Models;

namespace ProdMvc.Controllers;

public class ProductController : Controller{
    private readonly  SRKDbContext context;
    public ProductController(SRKDbContext _context){
        context= _context;
    }
    public IActionResult List(){
        var data= context.Product.ToList();
        return View(data);
    }

    public IActionResult Display(int id){
        var data=context.Product.Find(id);
        return View(data);
    }
}