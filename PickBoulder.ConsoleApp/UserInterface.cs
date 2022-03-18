using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PickBoulder.Repository;

namespace PickBoulder.ConsoleApp
{
    public class UserInterface
    {
        bool isRunning = true;
        BoulderRepository _repo = new BoulderRepository();
        CustomConsole _console = new CustomConsole();
        public void Run()
        {
            _repo.SeedData(); 

            while (isRunning)
            {
                _console.PrintMainMenu();
                // ViewAllBoulder();
                _console.EnterSelection();
                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        
        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    ViewAllBoulders();
                    break;
                case "2":
                    CreateABoulder();
                    break;
                case "3":
                    // Filter();
                    break;
                case "4":
                    // ExitApplication();
                    break;
                default:

                    break;
            }
        }
        //READ all method
        public void ViewAllBoulders()
        {
            List<Boulder> boulderList = _repo.GetAllBoulder();

            foreach (Boulder boulder in boulderList)
            {
                _console.PrintBoulder(boulder);
            }

            _console.PressAnyKeyToContinue();
        }

        //Create 
        private void CreateABoulder()
        {
            _console.EnterAName();
            string boulderName = GetUserInput();

            _console.EnterDifficulty();
            int difficulty = Convert.ToInt32(GetUserInput());

            _console.EnterLocation();
            string location = GetUserInput();

            _console.PrintRockTypes();
            _console.EnterSelection();

            string typeOfRockInput = GetUserInput();

            RockType typeOfRock = RockType.Granite;

            switch (typeOfRockInput)
            {
                case "1":
                    typeOfRock = RockType.Granite;
                    break;
                case "2":
                    typeOfRock = RockType.Sandstone;
                    break;
                case "3":
                    typeOfRock = RockType.Limestone;
                    break;
                case "4": 
                    typeOfRock = RockType.Quartzite;
                    break;
                case "5": 
                    typeOfRock = RockType.Slate;
                    break;
                default:
                    break;
            }

            _console.EnterHeight();
            int height = Convert.ToInt32(GetUserInput());

            Boulder newBoulder = new Boulder(boulderName, difficulty, location, typeOfRock, height);

            _repo.AddBoulderToList(newBoulder);

            _console.PressAnyKeyToContinue();
        }

    }
        
    public class CustomConsole
    {
              
        public void PrintMainMenu()
        {
            Console.WriteLine("1. View all Boulder.\n" +
                "2. Add a Boulder.\n" //+
                // "3. Filter Boulders.\n" +
                // "4. EXIT."
                );
        }

        public void EnterSelection()
        {
            Console.Write("Enter Selection: ");
        }

        public void PrintBoulder(Boulder boulder)
        {
           Console.WriteLine($"{boulder.BoulderName} is V{boulder.Difficulty} in {boulder.Location} it is {boulder.TypeOfRock} and {boulder.Height}ft tall which makes it a higball boulder? {boulder.IsHighball}");
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("\nPress any key to continue....");
            Console.ReadKey();
        }

        public void EnterAName()
        {
            Console.Write("Name: ");
        }
        public void EnterDifficulty()
        {
            Console.Write("Enter Difficulty: ");
        }

        public void EnterLocation()
        {
            Console.Write("Location: ");
        }

        public void EnterHeight()
        {
            Console.Write("Height: ");
        }

        public void PrintRockTypes()
        {
            Console.WriteLine("Rock Type:\n" +
                    "1. Granite\n" +
                    "2. Sandstone\n" +
                    "3. Limestone\n" +
                    "4. Quartzite\n" +
                    "5. Slate");
        }

    }

}
