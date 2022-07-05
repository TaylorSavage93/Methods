namespace Exercise_2_Methods
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            var answer = (num1 * num2);
            return answer;
        }
        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }



        static void Main(string[] args)
        {
            var amountofDogs = Subtract(10, 5);
            Console.WriteLine(amountofDogs);

            var amountofLeashes = Multiply(10, 1);
                Console.WriteLine(amountofLeashes);

            var amountofOwners = Divide(10,2);
            Console.WriteLine(amountofOwners);

            var amountofMoney = Add(15,15);
            Console.WriteLine(amountofMoney);






        }
    }
}