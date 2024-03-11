using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreCodeFirst.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst.DataAccess.Concrete.EntityFramework.Contexts;
public class EfCoreCodeFirstContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=AKINCENGIZ;Initial Catalog=EfCoreCodeFirstDB;Integrated Security=True;Trust Server Certificate=True;");
	}

	public DbSet<Category> Categories { get; set; }
	public DbSet<Supplier> Suppliers { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Employee> Employees { get; set; }
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Shipper> Shippers { get; set; }
	public DbSet<Order> Orders { get; set; }
}
