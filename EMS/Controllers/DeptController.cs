using EMS.Models;
using Microsoft.AspNetCore.Mvc;
namespace EMS.Controllers;
public class DeptController:Controller{
    private readonly EmsDbContext context;
    public DeptController(EmsDbContext _context){
        context = _context;
    }
public IActionResult List(){
    return View();
}
}