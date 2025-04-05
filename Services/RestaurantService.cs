using FoodNow.Models;

public class RestaurantService
{
    private List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant
        {
            Id = 1,
            Name = "Pizzeria Bella",
            Address = "Str. Memorandumului, Nr. 5, Cluj-Napoca",
            Description = "Pizzeria Bella aduce în inima orașului un colț de Italia autentic, cu pizza proaspăt preparată, folosind ingrediente de calitate superioară. Atmosfera prietenoasă și designul modern fac din Pizzeria Bella locul perfect pentru o cină de neuitat alături de cei dragi.",
            Products = new List<Product>
            {
                new Product { IdRestaurant = 1, Name = "Pizza Margherita", Description = "Pizza cu sos de roșii și mozzarella.", Cost = 25.5 },
                new Product { IdRestaurant = 1, Name = "Pizza Quattro Stagioni", Description = "Pizza cu patru tipuri de ingrediente.", Cost = 30.0 }
            }
        },
        new Restaurant
        {
            Id = 2,
            Name = "Burger House",
            Address = "Bd. Eroilor, Nr. 23, Cluj-Napoca",
            Description = "Burger House este locul unde burgerii suculenți și cartofii crocanți sunt combinați perfect pentru a-ți oferi o masă satisfăcătoare. Folosim doar carne de calitate, iar fiecare burger este gătit cu pasiune pentru gusturi autentice. Vino și încearcă cele mai bune burgeruri din oraș!",
            Products = new List<Product>
            {
                new Product { IdRestaurant = 2, Name = "Cheeseburger", Description = "Burger clasic cu brânză și carne suculentă.", Cost = 15.0 },
                new Product { IdRestaurant = 2, Name = "Double Burger", Description = "Burger cu două straturi de carne.", Cost = 20.0 }
            }
        },
        new Restaurant
        {
            Id = 3,
            Name = "Sushi World",
            Address = "Str. Republicii, Nr. 109, Cluj-Napoca",
            Description = "Sushi World îți aduce la masă cele mai proaspete preparate din sushi, gătite de maeștri sushi. Cu o selecție largă de sushi nigiri, maki și sashimi, Sushi World este locul ideal pentru iubitorii de sushi, oferind o experiență culinară rafinată și o atmosferă calmă și relaxantă.",
            Products = new List<Product>
            {
                new Product { IdRestaurant = 3, Name = "Sushi Nigiri", Description = "Sushi cu somon proaspăt.", Cost = 50.0 },
                new Product { IdRestaurant = 3, Name = "Sashimi", Description = "Pește proaspăt tăiat fin.", Cost = 40.0 }
            }
        }
    };

    public List<Restaurant> GetAllRestaurants()
    {
        return restaurants;
    }

    public Restaurant GetDefaultRestaurant()
    {
        return restaurants.FirstOrDefault(); // Sau poate fi un restaurant specificat, de exemplu:
        // return restaurants.FirstOrDefault(r => r.Id == 1); // pentru primul restaurant
    }

    public Restaurant GetRestaurantById(int id)
    {
        return restaurants.FirstOrDefault(r => r.Id == id);
    }

    public List<Product> GetProductsByRestaurantId(int restaurantId)
    {
        return restaurants.FirstOrDefault(r => r.Id == restaurantId)?.Products ?? new List<Product>();
    }
}