using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    internal class BanUser
    {
        public static void Handle()
        {
            Console.WriteLine("Privacy settings");
            Console.WriteLine();
            Console.Write("Please enter user Email:");
            string inputEmail = Console.ReadLine()!;
            foreach (User user in DataContext.Users)
            {
                if (user.Email == inputEmail)
                {
                    while (true)
                    {

                        Console.WriteLine();
                        Console.Write("You want to block this person exactly?:(please answer YES or NO)");
                        string banCommand = Console.ReadLine()!;
                        if(banCommand != null)
                        {
                            if(banCommand == "YES" && banCommand != "NO")
                            {
                                user.IsBanned = true;
                                Console.WriteLine($"INFO!!!:This {" " + user.LastName + " " + user.Name + " "} account has been blocked by the admin from now on!!!");
                                return;
                            }
                            if(banCommand == "NO" && banCommand != "YES")
                            {
                                return;
                            }
                        }
                    
                    }

                }



            }
            Console.WriteLine();
            Console.WriteLine("The email you entered is not valid in the database!!!");
            return;














        }
    }
}
    
    
    
    
    
    
    
    
