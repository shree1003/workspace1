using Microsoft.AspNetCore.Mvc;
namespace EMS.Controllers;
public class EmpController:Controller{
public IActionResult List(){
    return View();
}
}