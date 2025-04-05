using FoodNow.Models;
using System.Collections.Generic;

public class ShoppingCartService
{
    public List<Product> CartItems { get; private set; } = new(); // Folosim Product în loc de CartItem
    public Order? LastOrder { get; private set; }

    public void AddToCart(Product product)
    {
        var existingItem = CartItems.Find(item => item.Name == product.Name);
        if (existingItem != null)
        {
            // Dacă produsul există deja în coș, creștem cantitatea
            // În acest caz, presupunem că folosim "Price" pentru a calcula totalul
            // Este posibil să vrei să adaugi un atribut Quantity în Product pentru a gestiona cantitățile
            existingItem.Quantity++;
        }
        else
        {
            // Dacă produsul nu este în coș, îl adăugăm
            CartItems.Add(new Product
            {
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                IdRestaurant = product.IdRestaurant,
                Quantity = 1 // Adăugăm un câmp de cantitate în Product
            });
        }
    }

    public void RemoveFromCart(string name)
    {
        var item = CartItems.Find(item => item.Name == name);
        if (item != null)
        {
            CartItems.Remove(item);
        }
    }

    public void ClearCart()
    {
        CartItems.Clear();
    }

    public void PlaceOrder()
    {
        if (CartItems.Count > 0)
        {
            // Creăm comanda, folosind lista de produse din coș
            LastOrder = new Order
            {
                Items = new List<Product>(CartItems), // Copiem produsele din coș
                Cost = GetTotal(),
                Date = DateTime.Now, // Presupunem că data comenzii este acum
                Status = "In progress" // Statusul comenzii
            };
            ClearCart(); // Golește coșul după plasarea comenzii
        }
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (var item in CartItems)
        {
            total += item.Cost * item.Quantity;
        }
        return total;
    }
}
