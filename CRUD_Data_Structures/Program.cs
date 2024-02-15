using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Data_Structures
{
    //Car Class
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }

    internal class Program
    {
        static Car[] cars = new Car[10]; // Array of Car objects

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("WELCOME TO PORSCHE CONFIGURATOR"); //Main menu loop
                Console.WriteLine("\n1. Add Car");
                Console.WriteLine("2. Edit Car");
                Console.WriteLine("3. Delete Car");
                Console.WriteLine("4. Display Car");
                Console.WriteLine("5. Display All Cars");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCar();
                        break;
                    case 2:
                        EditCar();
                        break;
                    case 3:
                        DeleteCar();
                        break;
                    case 4:
                        DisplayCar();
                        break;
                    case 5:
                        DisplayAllCars();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        //Add a new car function
        static void AddCar()
        {
            Console.WriteLine("\nEnter Car details:");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = new Car { Brand = brand, Model = model, Year = year };
                    Console.WriteLine("Car added successfully!");
                    return;
                }
            }
            Console.WriteLine("Array is full. Cannot add more cars.");
        }

        //Edit a car info function
        static void EditCar()
        {
            Console.Write("\nEnter index of Car to edit: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Car details:");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            cars[index].Brand = brand;
            cars[index].Model = model;
            cars[index].Year = year;
            Console.WriteLine("Car details updated successfully!");
        }

        //Delete a car info function
        static void DeleteCar()
        {
            Console.Write("\nEnter index of Car to delete: ");
            int index = int.Parse(Console.ReadLine());
            cars[index] = null;
            Console.WriteLine($"Car at index {index} deleted successfully!");
        }

        //Display a car data function
        static void DisplayCar()
        {
            Console.Write("\nEnter index of Car to display: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nCar details at index {index}:");
            Console.WriteLine($"Brand: {cars[index].Brand}:");
            Console.WriteLine($"Model: {cars[index].Model}:");
            Console.WriteLine($"Year: {cars[index].Year}:");

        }

        //Display all data function
        static void DisplayAllCars()
        {
            Console.WriteLine("\nAll Cars info is:");
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                {
                    Console.WriteLine($"Index {i}: {cars[i]}");
                }
            }
        }
    }

}
