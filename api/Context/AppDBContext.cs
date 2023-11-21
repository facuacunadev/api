using api.Entities;
using api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.Context;
public class AppDBContext : DbContext, IAppDBContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {

    }
    public DbSet<Post> Post { get; set; }
    public DbSet<Categorias> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder
        //.UseSqlServer(
        //    @"Server=127.0.0.1,14333;Database=API;user id=sa;password=M1sterPassw0rd!;",
        //@"Server=mssql,14333;Database=API;user id=sa;password=M1sterPassw0rd!;TrustServerCertificate=true;Trusted_Connection=True;",
        //options => options.EnableRetryOnFailure());

        //optionsBuilder.UseSqlServer(
        //    @"Server=206.189.253.20,14333;Database=API;user id=sa;password=Global2020!;");
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        return base.SaveChangesAsync(cancellationToken);
        
    }

}
