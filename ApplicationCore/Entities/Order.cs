using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int ShipperId { get; set; }
    public DateTime OrderDate { get; set; }
    [Column(TypeName="varchar(60)")]
    [Required (ErrorMessage ="Shipping address is required")]
    public required string ShipAddress { get; set; }
    [Column(TypeName="varchar(15)")]
    [Required (ErrorMessage ="Shipping city is required")]
    public required string ShipCity { get; set; }

    public Customer Customer { get; set; }
    public Shipper Shipper { get; set; }
}