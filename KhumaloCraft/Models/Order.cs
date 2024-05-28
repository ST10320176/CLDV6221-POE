using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // PK
        public string? Status { get; set; }
        public string? Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public int? AmountItems { get; set; }

        //Navigation property for Order_Product
        public List<Order_Product>? Order_Product { get; set; }

    }
}
