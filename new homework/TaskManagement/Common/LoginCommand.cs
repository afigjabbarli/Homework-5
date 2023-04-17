using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            Console.Write("Please enter your email:");
            string email = Console.ReadLine()!;
            Console.Write("Please enter your password:");
            string password = Console.ReadLine()!;

            for (int i = 0; i < DataContext.Users.Count; i++)
            {
                User user = DataContext.Users[i];

                 if(user.IsBanned ==  false)
                 {
                    if (user.Email == email && user.Password == password)
                    {
                       if (user.IsAdmin)
                       {
                           AdminDashboard.Introduction();
                       }
                       else
                       {
                           ClientDashboard.Introduction(user);
                       }
                    }
                 }
                else
                {
                    Console.WriteLine($"Dear {" " + user.LastName + " " + user.Name + " "} your account has been blocked by admin!!!");
                    return;
                }


            }
        }
    }
}
