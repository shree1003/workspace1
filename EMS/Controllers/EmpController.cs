using Microsoft.AspNetCore.Mvc;
namespace EMS.Controllers;
public class EmpController:Controller{
    private readonly EmsDbContext context;
    public EmpController(EmsDbContext _context){
        context= _context;
    }
    public IActionResult List(){
        var data=context.Employees.ToList();
        return View(data);
    }

    public IActionResult Create(){
        ViewBag.DeptId= new SelectList(context.Departments,"Id","DeptName");
        return View();
    }
    public IActionResult Create(Employee emp){
        if(ModelState.IsValid){
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        ViewBag.DeptId= new SelectList(context.Departments,"Id","DeptName");
        return View(emp);
    }
}