using System;

namespace firstChallenge_simpleCalculator {
    public class InputHandler {
        public int[] GetTwoNumbersFromUser() {
            MessageManager messageManager = new MessageManager();
            int[] nums = new int[2];
            messageManager.EnterFirstNumberMessage();
            nums[0] = GetIntInput();
            messageManager.EnterSecondNumberMessage();
            nums[1] = GetIntInput();
            return nums;
        }

        public int GetIntInput() {
            return Int32.Parse(Console.ReadLine());
        }
    }
}