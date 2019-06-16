using System;

namespace firstChallenge_simpleCalculator {
    public class MessageManager {
        public void ShowingMenu() {
            Console.WriteLine("=============================");
            Console.WriteLine("1. Add Two Number");
            Console.WriteLine("2. Reduce Two Number");
            Console.WriteLine("3. Multiple Two Number");
            Console.WriteLine("4. Divide Two Number");
            Console.Write("Enter Your choice: ");
        }

        public void ShowTheResult(int result) {
            Console.WriteLine("The result is: " + result);
        }

        public void EnterFirstNumberMessage() {
            Console.Write("Enter the first number: ");
        }
        
        public void EnterSecondNumberMessage() {
            Console.Write("Enter the second number: ");
        }
    }
}