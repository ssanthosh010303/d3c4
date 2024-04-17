/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-3 Challenge-4: Length of User's Name
 */
namespace Challenge4;

class Program
{
    static void Main()
    {
        string? userName;

        Console.Write("Enter name: ");
        userName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userName))
        {
            int nameLength = userName.Trim().Length;

            Console.WriteLine("\nResult");
            Console.WriteLine($"  Length: " + nameLength);
        }
    }
}
