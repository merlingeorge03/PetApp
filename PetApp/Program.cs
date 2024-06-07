using System;

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

            //Initial status of the pet is displayed - Implemented in Pet class 
            Console.WriteLine($"\n {petName}'s status \n\n\tHunger = 5 , \t Health =  5 , \t Happiness = 5");

            //Display the menu that include the options to interact with the pet and perform actions 
            displayMainMenu();

        }

        static void askPetType()
        {
            Console.Write("\nPlease choose a pet \n\t1. Cat\n\t2. Dog \n\t3. Rabbit\n");
            Console.Write("User Input: ");
            String choice = Console.ReadLine();


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
            Console.WriteLine($"\t1. Feed {petName}");
            Console.WriteLine($"\t2. Play with {petName}");
            Console.WriteLine($"\t3. Let {petName} Rest");
            Console.WriteLine($"\t4. Check {petName}'s Status");
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
            switch (action)
            {
                //Invoke actions as per User's choice and display mainmenu after performing the actions
                case "1":
                    pet.feed();
                    displayMainMenu();
                    break;

                case "2":
                    pet.play();
                    displayMainMenu();
                    break;

                case "3":
                    pet.rest();
                    displayMainMenu();
                    break;

                case "4":
                    pet.printStatus();
                    displayMainMenu();
                    break;

                case "5":
                    // Exit from the app
                    Console.WriteLine("Exiting the application, GoodBye !\n");
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try again");
                    break;
            }

        }
    }



    public class Pet
    {
        public string name;
        public int hunger;
        public int happiness;
        public int health;

        public Pet(string name)
        {
            this.name = name;
            //Initial values are set to 5
            this.hunger = 5;
            this.happiness = 5;
            this.health = 5;
        }

        public void feed()
        {
            //Modify hunger and health values only if it is within range 0 and 10
            if (hunger >= 0 && hunger < 10)
            {
                hunger -= 1;

                if (health >= 0 && health < 10)
                {
                    ++health;
                }

                Console.WriteLine($"\n\t You fed {name}. His hunger decreases, and health improves slightly.");
               
                //Printing the status post performing feed action
                printStatus();
            }
            else
            {
                Console.WriteLine($"\n\t {name} is already full and not hungry.");
            }

        }

        public void play()
        {
            //Modify hunger and happiness values only if it is within range 0 and 10
            if (hunger >= 0 && hunger < 10)
            {
                hunger = hunger + 1;

                if (happiness >= 0 && happiness < 10)
                {
                    ++happiness;
                }

                Console.WriteLine($"\n\t You played with {name}. His Happiness increases, but he's a bit hungrier.");
                
                //Printing the status post performing play action
                printStatus();
            }
            else if (hunger >= 10)
            {
                Console.WriteLine($"\n\t{name} is already really hungry and can't play anymore");
            }

        }

        public void rest()
        {
            //Modify happiness and health values only if it is within range 0 and 10

            if (happiness >= 0 && happiness < 10)
            {
                happiness = happiness - 1;

                if (health >= 0 && health < 10)
                {
                    ++health;
                }

                Console.WriteLine($"\n\t {name} took rest. His health increases, but his happiness decreases.");
              
                //Printing the status post performing rest action
                printStatus();
            }
            else
            {
                Console.WriteLine($"\n\t{name} has rested well, but he's very sad. Please play with him");
            }

        }

        //Method to print the updated values of hunger, health and happiness
        public void printStatus()
        {
            Console.WriteLine($"\n {name}'s status \n\n\tHunger = {hunger} , \t Health =  {health} , \t Happiness = {happiness}");

        }
    }

}
