using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user)
        {
            Console.WriteLine($"Hello! : {user.Email} {user.Password}");
            Console.WriteLine();
            Console.WriteLine("Choose the one of the commands");
            Console.WriteLine();
            Console.WriteLine("|Update-settings|");
            Console.WriteLine("|Close-account|");
            Console.WriteLine("|Messages|");
            Console.WriteLine();
            while(true)
            {
                 Console.Write("Please enter command:");
                 string userCommand = Console.ReadLine()!;
                 Console.WriteLine();
                 switch(userCommand)
                 {
                    case "Update-settings":
                        UpdateUserSettings.Handle();
                    break;

                    case "Close-account":
                        CloseAccount.Handle();
                    break;

                    case "Messages":
                        Messages.Handle();
                        break;

                    default: Console.WriteLine("Invalid command, pls try again");
                        break;
                 }
            }

        }
    }




























}
