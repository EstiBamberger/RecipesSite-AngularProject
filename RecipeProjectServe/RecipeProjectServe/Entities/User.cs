namespace RecipeProjectServe.Entities
{
    public class User
    {
        public static int count = 0;
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(User u)
        {
            this.Id = count++;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Email = u.Email;
            this.Password = u.Password;

        }
        public User() { }
    }
}
