namespace firstChallenge_simpleCalculator {
    public class Calculator {
        public int Add(int a,int b) {
            return a+ b;
        }

        public int Reduce(int a,int b) {
            return a - b;
        }

        public int Multiple(int a,int b) {
            return a * b;
        }

        public int Divide(int a,int b) {
            if (b == 0) {
                /*throw new exception*/
                return -1000;
            }

            return a / b;
        }
    }
}