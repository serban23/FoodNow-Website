namespace FoodNow.Models
{
    public class Order
    {
        public List<Product> Items { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }
        public string Status { get; set; }
    }
}
