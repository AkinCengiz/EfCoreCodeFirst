using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreCodeFirst.Entity.Abstract;

namespace EfCoreCodeFirst.Entity.Concrete;
public class Shipper : IEntity
{
	[Key]
	public int ShipperId { get; set; }
	[MaxLength(40)]
	public string CompanyName { get; set; }
	[MaxLength(24)]
	public string? Phone { get; set; }
}
