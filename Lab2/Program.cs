using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            float userWidth = -1;
            float userLength = -1;
            float roomPerimeter = -1;
            float roomArea = -1;
            float roomHeight = -1;
            float roomVolume = -1;
            bool goAgain = true;


            do
            {
            BeginCalcs:

                //Main loops to gather the Length and Width
                do
                {
                    Console.WriteLine("Hello, please enter in the length of the room: ");
                    userInput = Console.ReadLine();
                    userLength = float.Parse(userInput);

                } while (userLength == -1);

                do
                {
                    Console.WriteLine("Now enter in the width of the room: ");
                    userInput = Console.ReadLine();
                    userWidth = float.Parse(userInput);


                } while (userWidth == -1);

                //Outputs for the area and perimeter of the room
                Console.WriteLine($"{roomPerimeter = 2 * (userLength + userWidth)} is the perimeter of the room, and the area is {roomArea = userLength * userWidth}.");

                //Asking for input on the height of the room
                Console.WriteLine("Would you like to calculate the Volume? (Yes/No)");
                string secondInput = Console.ReadLine();

                //If the user would like to calculate volume, otherwise, see if they want to continue.
                switch (secondInput.ToLower().Trim())
                {
                    case "yes":
                        Console.WriteLine("What is the height of the room?: ");
                        string thirdInput = Console.ReadLine();
                        roomHeight = float.Parse(thirdInput);

                        Console.WriteLine($"The volume of the room is {userLength * userWidth * roomHeight}");

                        goto TryAgain;
                    case "no":
                        goto TryAgain;
                }
            //if they want to go again go to beginning on line 19 otherwise, exit
            TryAgain:

                Console.WriteLine("Would you like to go again? (Yes/No)");
                userInput = Console.ReadLine();

                switch (userInput.ToLower().Trim())
                {
                    case "yes":
                        goto BeginCalcs;
                    case "no":
                        Console.WriteLine("Good Bye!");
                        goAgain = false;
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }


            } while (goAgain == true); //Only continues the do while (begin line 19) while goAgain = true


        }
    }
}
