namespace FoodNow.Models
{
    public class User
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string DeliveryAddress { get; set; }

        public User(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }


    }
}
