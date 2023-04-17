using TaskManagement.Common;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the commands");
            Console.WriteLine();
            Console.WriteLine("|Register|");
            Console.WriteLine("|Login|");
            Console.WriteLine("|Exit|");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "Register":
                        RegisterCommand.Handle();
                        break;
                    case "Login":
                        LoginCommand.Handle();
                        break;
                    case "Exit":
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
