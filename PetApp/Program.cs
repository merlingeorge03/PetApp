using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetApp
{
    internal class PetLogic
    {
        static String petName;
        static String actionSelected;
        static bool initialStatus = true;
        static Pet pet;

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Virtual Pet App");

            // Asking users choice for pet type and display the choice selected.
            askPetType();

            // Asking users choice for pet name and display a welcome message for pet.
            askPetName();

            Console.WriteLine($"\n {petName}'s status \n\n\tHunger = 5 , \t Health =  5 , \t Happiness = 5");
            
            //Display the menu that include the options to interact with the pet and perform actions 
            displayMainMenu();

        }

        static void askPetType()
        {
            Console.Write("\nPlease choose a pet \n\t1. Cat\n\t2. Dog \n\t3. Rabbit\n");
            Console.Write("User Input: ");
            String choice = Console.ReadLine();
            if (choice != null)
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nYou've chosen a Cat. What would you like to name your pet?");
                        break;
                    case "2":
                        Console.WriteLine("\nYou've chosen a Dog. What would you like to name your pet?");
                        break;
                    case "3":
                        Console.WriteLine("\nYou've chosen a Rabbit. What would you like to name your pet?");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Kindly enter a number between 1 and 3");
                        askPetType();
                        break;
                }

            }
            else
            {
                Console.WriteLine("\nInvalid choice. Kindly enter a number between 1 and 3");
                askPetType();
            }
        }


        static void askPetName()
        {
            Console.WriteLine("\nEnter the pet name");
            petName = Console.ReadLine();
            pet = new Pet(petName);
            Console.WriteLine($"\nWelcome, {petName}! Let's take a good care of him.\n");
        }

        static void displayMainMenu()
        {
            //Options in the MainMenu
            Console.WriteLine("\nMainMenu options\n");
            Console.WriteLine("\t1. Feed Buddy");
            Console.WriteLine("\t2. Play with Buddy");
            Console.WriteLine("\t3. Let Buddy Rest");
            Console.WriteLine("\t4. Check Buddy's Status");
            Console.WriteLine("\t5. Exit");
            Console.WriteLine("\nPlease choose an option\n");

            Console.Write("User Input: ");
            actionSelected = Console.ReadLine();

            //Perform the actions based on the option selected by the user
            PetLogic petLogic = new PetLogic();
            petLogic.performAction(petName, actionSelected);

        }

        public void performAction(string name, string action)
        {

            if (action != null)
            {
                switch (action)
                {
                    case "1":
                        pet.feed();
                        displayMainMenu();
                        break;

                    case "2":
                        //call play method
                        //displayMainMenu();
                        break;

                    case "3":
                        //call rest method
                       // displayMainMenu();
                        break;

                    case "4":
                        pet.printStatus();
                        //displayMainMenu();
                        break;

                    case "5":
                        // Exit from the app
                        Console.WriteLine("Exiting the application, GoodBye !");
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Please try again");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Option. Please choose a valid option between 1 and 5");
            }

        }
    }



    public class Pet
    {
        public string name;
        public int hunger;
        public int happiness;
        public int health;
        public bool initialStatus;

        public Pet(string name)
        {
            this.name = name;
            this.hunger = 5;
            this.happiness = 5;
            this.health = 5;
        }

        public void feed()
        {

            if (hunger > 0 && hunger < 10)
            {
                hunger -= 1;

                if (health >=0 && health < 10)
                {
                    ++health;
                }
                
                Console.WriteLine($"\t You fed {name}. His hunger decreases, and health improves slightly.");
                initialStatus = false;
                printStatus();
            }
            else
            {
                Console.WriteLine($"{name} is already full and not hungry");
            }

        }

        public void play()
        {

            if (hunger > 0 && hunger < 10)
            {
                hunger = hunger+1;

                if (health >= 0 && health < 10)
                {
                    ++health;
                }

                Console.WriteLine($"\t You fed {name}. His hunger decreases, and health improves slightly.");
                initialStatus = false;
                printStatus();
            }
            else
            {
                Console.WriteLine($"{name} is already full and not hungry");
            }

        }


        public void printStatus()
        {
                Console.WriteLine($"\n {name}'s status \n\nHunger = {hunger} , \t Health =  {health} , \t Happiness = {happiness}");
            
        }
    }

}
