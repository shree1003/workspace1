using System.ComponentModel.DataAnnotations;
namespace ProdMvc.Models;

public class Product{
    [Display(Name="Product Id")]
    [Key]
    [Required(ErrorMessage="Id is compulsory")]
    public int Id{get;set;}
    [Required(ErrorMessage="Name cannot be NULL")]
    public string ?Name{get;set;}
    [Range(1000,90000,ErrorMessage="Price should be between 100 to 900")]
    public int Price{get;set;}
    public int Stock{get;set;}
}