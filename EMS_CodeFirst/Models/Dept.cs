using System.ComponentModel.DataAnnotations;

namespace EMS_CodeFirst.Models;

public class Dept{
    public int Id{get;set;}
    [Required(ErrorMessage="Name cannot be blank")]
    [MaxLength(30)]
    public string Name{get;set;}
[MaxLength(30)]
    public string Location{get;set;}
}