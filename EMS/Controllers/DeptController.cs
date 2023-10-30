using EMS.Models;
using Microsoft.AspNetCore.Mvc;
namespace EMS.Controllers;
public class DeptController:Controller{
    private readonly EmsDbContext context;
    public DeptController(EmsDbContext _context){
        context = _context;
    }
public IActionResult List(){
    //var data=context.Departments.ToList();
    List<Department> data= null;
    try{
        data=context.Departments.ToList();
        if(data.Count==0)
        throw new Exception();
    }
    catch(System.Exception ex){
        ViewBag.ErrorMessage="0 records present";
        return View("Error");
    }
    return View(data);
}
public IActionResult Create(){
    return View();
}
[HttpPost]
public IActionResult Create(Department department){
    if(ModelState.IsValid){
        context.Departments.Add(department);
        context.SaveChanges();
        return RedirectToAction("List");

    }
    return View();
}
}