using System.ComponentModel.DataAnnotations;
namespace EmpMVC.Models;
public class Product{
    [Display(Name = "Product ID")]
    [Key]
    [Required(ErrorMessage = "Id is compulsory")]
    public int Id{get;set;}
    
    
    [Required(ErrorMessage = "Name cannot be blank")]
    public string Name{get;set;}
    
    
    [Range(100,90,ErrorMessage= "Price should be between 100 and 900")]
    public int Price{get;set;}

    public int Stock{get;set;}
}