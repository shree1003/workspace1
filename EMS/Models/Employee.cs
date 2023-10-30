﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EMS.Models;

public partial class Employee
{
    public int EmpId { get; set; }

[Required(ErrorMessage ="Name is Required")]
    public string Name { get; set; } = null!;

[Range(10000,90000,ErrorMessage ="Salary range is 10000-90000")]
    public int Salary { get; set; }
    [Display(Name="Department")]

    public int DeptId { get; set; }
    [Display(Name="Email")]
    [DataType(DataType.EmailAddress)]

    public string Email { get; set; } = null!;
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="0:yyyy-mm-dd")]

    public DateTime Dob { get; set; }

    public virtual Department Dept { get; set; } = null!;
}
