using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();

        static DataContext()
        {
            AddUserSeeedings();
        }

        public DataContext()
        {
            AddUserSeeedings();
        }

        private static void AddUserSeeedings()
        {
            Users.Add(new User("Mahmood", "Garibov", "321123", "qaribv@gmail.com", true));
            Users.Add(new User("Eshgin", "Farajov", "123321", "eshginaf@code.edu.az", true));
        }
    }
}
