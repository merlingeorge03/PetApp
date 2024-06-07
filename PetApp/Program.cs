using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetApp
{
    internal class PetLogic
    {
        static String petName;
        static int actionSelected;
        Pet pet;

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Virtual Pet App");

            // Asking users choice for pet type and display the choice selected.
            askPetType();

            // Asking users choice for pet name and display a welcome message for pet.
            petName=askPetName();

            //Display the menu that include the options to interact with the pet and perform actions 
            actionSelected = displayMainMenu();

            //Perform the actions based on the option selected by the user
            performAction(petName, actionSelected);
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


        static string askPetName()
        {
            Console.WriteLine("\nEnter the pet name");
            petName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {petName}! Let's take a good care of him.\n");
            return petName;
        }

        static int displayMainMenu()
        {
            //Options in the MainMenu
            Console.WriteLine("\n\tMain Menu:\n");
            Console.WriteLine("\t1. Feed Buddy");
            Console.WriteLine("\t2. Play with Buddy");
            Console.WriteLine("\t3. Let Buddy Rest");
            Console.WriteLine("\t4. Check Buddy's Status");
            Console.WriteLine("\t5. Exit");
            Console.WriteLine("\n\tSelect an option \n");

            return int.Parse(Console.ReadLine());
        }

        static void performAction(string name, int action)
        {
            Console.WriteLine("User Input:" +action);

            switch (action)
            {
                case 1:
                    Console.WriteLine("inside switch statement");
                    Console.WriteLine($"Inside case 1: petname {name}, Action : " + action);
              
                    break;

                case 2:
                    //call play method
                    break;
                case 3:
                    //call rest method
                    break;
                case 4:
                    //call status method
                    break;
                case 5:
                    // Exit from the app
                    Console.WriteLine("Exiting the application, GoodBye !");
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try again");
                    break;
            }
            Console.WriteLine("outside switch statement");

        }
    }



    public class Pet
    {

    }

}
