using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } //PK
        public string? Name { get; set; }

        public string? Destination { get; set; }

        public decimal? Price { get; set; }

        //Navigation property for Order_Product
        public List<Order_Product>? Order_Product {get; set;}


    }
}
