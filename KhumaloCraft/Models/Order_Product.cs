using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class Order_Product
    { //Bridge entity

        [Key]
        public int OrderProductId { get; set; } //PK

        public string? ProductName { get; set; }

        public string? Destination { get; set; }
        public decimal? Price { get; set; }

        public Boolean availability {  get; set; }

        //Navigation properties
        public Order? Order { get; set; } //FK
        public Product? Product { get; set; } //FK
        
        public Order1? Order1 { get; set; }//FK
    }
}
