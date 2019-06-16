using System;

namespace firstChallenge_simpleCalculator {
    internal class Program {
        public static void Main(string[] args) {
            InputHandler inputHandler = new InputHandler();
            Calculator calc = new Calculator();
            MessageManager messageManager = new MessageManager();

            messageManager.ShowingMenu();
            int userChoice = inputHandler.GetIntInput();
            if (userChoice == 0) {
                Console.WriteLine("=============BYE BYE==========");
                return;
            }
            
            int[] nums = inputHandler.GetTwoNumbersFromUser();    
            while (true) {
                switch (userChoice) {
                    case 1:
                        messageManager.ShowTheResult(
                            calc.Add(nums[0], nums[1])
                        );
                        break;
                    case 2:
                        messageManager.ShowTheResult(
                            calc.Reduce(nums[0], nums[1])
                        );
                        break;
                    case 3:
                        messageManager.ShowTheResult(
                            calc.Multiple(nums[0], nums[1])
                        );
                        break;
                    case 4:
                        messageManager.ShowTheResult(
                            calc.Divide(nums[0], nums[1])
                        );
                        break;
                    default:
                        Console.WriteLine("=============================================================");
                        Console.WriteLine("WRONG CHOICE! TRY AGAIN");
                        Console.WriteLine("=============================================================");
                        break;
                }
                
                messageManager.ShowingMenu();
                userChoice = inputHandler.GetIntInput();
                if (userChoice == 0) {
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("=============BYE BYE==========");
                    Console.WriteLine("=============================================================");
                    return;
                }
                nums = inputHandler.GetTwoNumbersFromUser();   
            }
        }
    }
}