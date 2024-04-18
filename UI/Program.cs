using SneakerBoxBL;
using SneakerBox;
namespace SneakerBoxUI
{
    using System;
    using System.Collections.Generic;

    //ASSIGNMENT
    namespace SneakerBoxUI
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                SneakerBoxBLogic bl = new SneakerBoxBLogic();
                bool result = bl.VerifyUser(username, password);

                if (result)
                {
                    Console.WriteLine("Login Successful");

                    Console.WriteLine("Welcome to my Shoe Closet!!!!");
                    Console.WriteLine("Available Brands:");
                    Console.WriteLine("1. Nike");
                    Console.WriteLine("2. Adidas");
                    Console.WriteLine("3. New Balance");

                    Console.Write("Enter the number of the brand: ");
                    int brandChoice;
                    while (!int.TryParse(Console.ReadLine(), out brandChoice) || brandChoice < 1 || brandChoice > 3)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                        Console.Write("Enter the number of the brand: ");
                    }

                    ShoeModel shoeModel = new ShoeModel();

                    switch (brandChoice)
                    {
                        case 1:
                            DisplayShoeInfo(shoeModel.NikeList);
                            break;
                        case 2:
                            DisplayShoeInfo(shoeModel.AdidasList);
                            break;
                        case 3:
                            DisplayShoeInfo(shoeModel.NBList);
                            break;
                        default:
                            Console.WriteLine("Invalid brand choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unsuccessful");
                }
            }

            static void DisplayShoeInfo(List<Shoes> shoes)
            {
                if (shoes.Count == 0)
                {
                    Console.WriteLine("No shoes available.");
                    return;
                }

                foreach (var shoe in shoes)
                {
                    Console.WriteLine($"Model: {shoe.model}, Description: {shoe.description}");
                }

                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a Shoe");
                Console.WriteLine("2. Remove a Shoe");
                Console.WriteLine("3. Exit ");
                Console.WriteLine(" Please select:  ");

                int menuPick;
                while (!int.TryParse(Console.ReadLine(), out menuPick) || menuPick < 1 || menuPick > 3)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    Console.Write("Enter your choice: ");
                }

                switch (menuPick)
                {
                    case 1:
                        Console.WriteLine("Enter the model of the shoe to add:");
                        string model = Console.ReadLine();

                        Console.WriteLine("Enter the description of the shoe:");
                        string description = Console.ReadLine();

                        Shoes newShoe = new Shoes { model = model, description = description };
                        shoes.Add(newShoe);

                        Console.WriteLine("Shoe added successfully.");
                        DisplayUpdatedShoeList(shoes);
                        break;
                    case 2:
                        Console.WriteLine("Enter the model of the shoe to remove:");
                        string modelToRemove = Console.ReadLine();

                        var shoeToRemove = shoes.Find(s => s.model == modelToRemove);
                        if (shoeToRemove != null)
                        {
                            shoes.Remove(shoeToRemove);
                            Console.WriteLine("Shoe removed successfully.");
                            DisplayUpdatedShoeList(shoes);
                        }
                        else
                        {
                            Console.WriteLine("Shoe not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("No changes were made.");
                        break;
                    default:
                        break;
                }
            }

            static void DisplayUpdatedShoeList(List<Shoes> shoes)
            {
                Console.WriteLine("Updated Shoe List:");
                foreach (var shoe in shoes)
                {
                    Console.WriteLine($"Model: {shoe.model}, Description: {shoe.description}");
                }
            }
        }
    }
}
