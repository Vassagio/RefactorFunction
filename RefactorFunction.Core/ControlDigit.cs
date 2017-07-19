namespace RefactorFunction.Core {
    public class ControlDigit {
        public int Calculate(long number) {
            var sum = 0;
            var isOddPosition = true;

            while (number > 0) {
                var digit = (int)(number % 10);
                if (isOddPosition)
                    sum += 3 * digit;
                else
                    sum += digit;
                number /= 10;
                isOddPosition = !isOddPosition;
            }

            var modulo = sum % 7;
            return modulo;
        }
    }
}