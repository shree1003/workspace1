using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProdMvc.Models;

public class SRKDbContext: DbContext{
    public virtual DbSet<Product> Product{get;set;}
    public SRKDbContext(){}
    public SRKDbContext(DbContextOptions<SRKDbContext> options): base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer( "User ID=sa;password=examlyMssql@123; server=localhost;Database=SRKDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
}