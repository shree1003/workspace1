using Microsoft.AspNetCore.Mvc;
namespace EMS.Controllers;
public class DeptController:Controller{
public IActionResult List(){
    return View();
}
}