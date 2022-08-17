namespace DataAccess.Concrete.EntityFramework
{
  using CoreLayer.Entities.Concrete;
  using Microsoft.EntityFrameworkCore;
  using Microsoft.Extensions.Configuration;
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Text;

  public class DatabaseContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
      }
    }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }

  }
}

