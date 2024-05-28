using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class Order1
    {
        [Key]
        public int OrderID { get; set; }

        public string ProductName { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }
        public int Quantity { get; set; }

        //Navigation property for Order_Product
        public List<Order_Product>? Order_Product { get; set; }
    }
}
