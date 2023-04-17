using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteToAdmin
    {
        public static void Handle()
        {

            Console.Write("Dear admin please insert your email:");
            string adminEmail = Console.ReadLine()!;
            foreach (User user in DataContext.Users)
            {
                if (user.Email == adminEmail)
                {
                    if (user.IsAdmin)
                    {
                        user.IsAdmin = false;
                        Console.WriteLine($"{user.Name} is now user");
                    }
                    else if (user.IsAdmin == false)
                    {
                        Console.WriteLine("You already user");
                        return;
                    }
                    else
                    {

                    }
                }
            }
            Console.WriteLine("The email you entered is not valid in the database");






















        }












    }
}
