using System.Linq;
using FoodNow.Models;

public class UserService
{
    private User? currentUser = null;
    public bool IsLoggedIn => currentUser != null;
    public User? CurrentUser => currentUser;

    private List<User> users = new List<User>
        {
            new User("client1@example.com", "password123", "Client"),
            new User("client2@example.com", "123456", "Client"),
            new User("curier1@example.com", "curierpass", "Curier")
        };

    public bool Register(string email, string password, string role)
    {
        if (users.Any(u => u.Email == email))
        {
            return false; // Email deja existent
        }

        var newUser = new User(email, password, role);
        users.Add(newUser);
        return true;
    }

    public bool Login(string email, string password)
    {
        var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            currentUser = user; // Referință directă la utilizatorul din listă
            return true;
        }
        return false;
    }

    public void Logout()
    {
        currentUser = null;
    }

    public void UpdateFirstName(string firstName)
    {
        if (currentUser != null)
        {
            currentUser.FirstName = firstName;
        }
    }

    public void UpdateLastName(string lastName)
    {
        if (currentUser != null)
        {
            currentUser.LastName = lastName;
        }
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        if (currentUser != null)
        {
            currentUser.PhoneNumber = phoneNumber;
        }
    }

    public void UpdateDeliveryAddress(string address)
    {
        if (currentUser != null)
        {
            currentUser.DeliveryAddress = address;
        }
    }


}
