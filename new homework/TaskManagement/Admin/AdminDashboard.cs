using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine("Hello dear admin");
            Console.WriteLine("Choose the one of the commands");
            Console.WriteLine();
            Console.WriteLine("|Promote-to-admin|");
            Console.WriteLine("|Depromote-from-admin|");
            Console.WriteLine("|Update-settings|");
            Console.WriteLine("|Remove-user|");
            Console.WriteLine("|Ban-user|");
            Console.WriteLine("|Message-to|");
            Console.WriteLine("|Show-users|");
            Console.WriteLine("|Show-user-by-email|");
            Console.WriteLine("|Show-user-by-id|");
            Console.WriteLine("|Add-user|");
            Console.WriteLine("|Logout|");

            while (true)
            {
                Console.Write("Please enter command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "Promote-to-admin":
                        PromoteToAdmin.Handle();
                        break;
                    case "Depromote-from-admin":
                        DepromoteToAdmin.Handle();
                        break;
                    case "Update-settings":
                        UpdateSettings.Handle(); 
                        break;
                    case "Remove-user":
                        RemoveUser.Handle();
                        break;
                    case "Ban-user":
                        BanUser.Handle();
                        break;
                    case "Message-to":
                        MessageTo.Handle();
                        break;
                    case "Show-users":
                        ShowUsersCommand.Handle();
                        break;
                    case "Show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "Show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "Add-user":
                        AddUserCommand.Handle();
                        break;
                    case "Logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;




                      
                }
            }
        }

    }
}
