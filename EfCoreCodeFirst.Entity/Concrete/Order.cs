using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreCodeFirst.Entity.Abstract;

namespace EfCoreCodeFirst.Entity.Concrete;
public class Order : IEntity
{
	[Key]
	public int OrderId { get; set; }
	[StringLength(5)]
	public string? CustomerId { get; set; }
	[ForeignKey("CustomerId")]
	public Customer Customer { get; set; }
	public int? EmployeeId { get; set; }
	[ForeignKey("EmployeeId")]
	public Employee Employee { get; set; }
	public DateTime? DateTime { get; set; }
	public DateTime? RequiredDate { get; set; }
	public DateTime? ShippedDate { get; set; }
	public int? ShipVia { get; set; }
	[ForeignKey("ShipVia")]
	public Shipper Shipper { get; set; }
	public decimal? Freight { get; set; }
	[MaxLength(40)]
	public string? ShipName { get; set; }
	[MaxLength(60)]
	public string? ShipAddress { get; set; }
	[MaxLength(15)]
	public string? ShipCity { get; set; }
	[MaxLength(15)]
	public string? ShipRegion { get; set; }
	[MaxLength(10)]
	public string? ShipPostalCode { get; set; }
	[MaxLength(15)]
	public string? ShipCountry { get; set; }

}
