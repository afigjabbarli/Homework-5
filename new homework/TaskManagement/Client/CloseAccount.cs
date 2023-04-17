using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    internal class CloseAccount
    {
        public static void Handle()
        {
            Console.WriteLine("Deleting your current account.");
            Console.WriteLine();
            Console.WriteLine("Please enter your password to delete your account");
            Console.Write("Password:");
            string inputPassword = Console.ReadLine()!;
            Console.WriteLine();
            foreach(User user in DataContext.Users)
            {
                if (user.Password == inputPassword)
                {
                    if(user.IsAdmin == true)
                    {
                        Console.WriteLine("This account is an admin account!!!");
                        return;
                    }

                    else
                    {
                        DataContext.Users.Remove(user);
                        Console.WriteLine("The current user's account has been deleted");
                        return;
                    }
                }
            }
            Console.WriteLine("The password you entered is incorrect!!!");
            return;
        }






                













    
    
    
    }
}
