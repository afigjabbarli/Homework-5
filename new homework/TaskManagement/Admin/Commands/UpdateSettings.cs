using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class UpdateSettings
    {
        public static void Handle()
        {
            Console.Write("Please enter your Email:");
            string inputEmail = Console.ReadLine()!;
            foreach(User user in DataContext.Users)
            {
                if(inputEmail == user.Email)
                {
                    Console.WriteLine("Your current information:");
                    Console.WriteLine($"Fullname:{user.LastName + " " + user.Name}, password: {user.Password}");
                    Console.Write("Please enter new first name:");
                    string newFirstName = Console.ReadLine()!;
                    Console.WriteLine($"From {user.Name} to {newFirstName}");
                    user.Name = null!;
                    user.Name = newFirstName;

                    Console.Write("Please enter new last name:");
                    string newLastName = Console.ReadLine()!;
                    Console.WriteLine($"From {user.LastName} to {newLastName}");
                    user.LastName = null!;
                    user.LastName = newLastName;

                    Console.Write("Please enter new password:");
                    string newPassword = Console.ReadLine()!;
                    Console.WriteLine($"From {user.Password} to {newPassword}");
                    user.Password = null!;
                    user.Password = newPassword;

                    Console.WriteLine($"Your information fullname:{newLastName + " " + newFirstName}, password:{newPassword} has been updated successfully. Thanks for using...");


                }
            }
        }


       




        
        









    
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
