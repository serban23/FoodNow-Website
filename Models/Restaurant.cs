namespace FoodNow.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; } // Listă cu produsele restaurantului

    }
}
