﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreCodeFirst.Entity.Abstract;

namespace EfCoreCodeFirst.Entity.Concrete;
public class Product : IEntity
{
	[Key]
	public int ProductId { get; set; }
	[MaxLength(40)]
	public string ProductName { get; set; }
	public int? SupplierId { get; set; }
	public Supplier Supplier { get; set; }
	public int? CategoryId { get; set; }
	public Category Category { get; set; }
	[MaxLength(20)]
	public string? QuantityPerUnit { get; set; }
	public decimal? UnitPrice { get; set; }
	public short? UnitsInStock { get; set; }
	public short? UnitsOnOrder { get; set; }
	public short? ReorderLevel { get; set; }
	public bool Discontinued { get; set; }
}
