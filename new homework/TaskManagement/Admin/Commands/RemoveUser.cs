using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public  class RemoveUser
    {
        public static void Handle()
        {
            Console.Write("Please enter eMail adrres:");
            string eMail = Console.ReadLine()!;
            foreach(User user in DataContext.Users)
            {
                if(user.Email == eMail)
                {
                    if (user.IsAdmin == true)
                    {
                        Console.WriteLine("The email address you entered is reserved for the admin");
                        return;
                    }
                    
                    DataContext.Users.Remove(user);
                    Console.WriteLine("Your information has been successfully deleted from the single database");
                    return;
                }
            }
                        
            Console.WriteLine(eMail + "is not found in a single information database");
            return;
                    
                    
                            
                            
                               
                            

                        
                        















        }
    }
}













