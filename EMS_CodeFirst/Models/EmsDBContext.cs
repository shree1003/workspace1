using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EMS_CodeFirst.Models;

public class Ems_CodeFirstContext: DbContext{
    public virtual DbSet<Dept> Depts{get;set;}
    public virtual DbSet<Employee> Employees{get;set;}
    public Ems_CodeFirstDBContext(){}
    public Ems_CodeFirstDBContext(DBContextOptions <Ems_CodeFirstDBContext> options): base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer( "User ID=sa;password=examlyMssql@123; server=localhost;Database=EmsDB;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
}