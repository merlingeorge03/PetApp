using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class PetLogic
    {
        static String petName;

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Virtual Pet App");

            // Asking users choice for pet type and display the choice selected.
            askPetType();

            // Asking users choice for pet name and display a welcome message for pet.
            askPetName();
        }

        static void askPetType()
        {
            int choice = 0;
            Console.WriteLine("\nPlease choose a pet \n\t1. Cat\n\t2. Dog \n\t3. Rabbit");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine($"User Input: {choice}");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYou've chosen a Cat. What would you like to name your pet?");
                    break;
                case 2:
                    Console.WriteLine("\nYou've chosen a Dog. What would you like to name your pet?");
                    break;
                case 3:
                    Console.WriteLine("\nYou've chosen a Rabbit. What would you like to name your pet?");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Kindly enter a number between 1 and 3");
                    askPetType();
                    break;
            }
        }


        static void askPetName()
        {
            Console.WriteLine("\nEnter the pet name");
            petName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {petName}! Let's take a good care of him.");
        }

    }

    public class Pet
    {

    }

}
