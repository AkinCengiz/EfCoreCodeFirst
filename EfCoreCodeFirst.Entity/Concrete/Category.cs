using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreCodeFirst.Entity.Abstract;

namespace EfCoreCodeFirst.Entity.Concrete;
public class Category : IEntity
{
	[Key]
	public int CategoryId { get; set; }
	[MaxLength(15)]
	public string CategoryName { get; set; }
	public string? Description { get; set; }
	public byte[]? Picture { get; set; }
}
