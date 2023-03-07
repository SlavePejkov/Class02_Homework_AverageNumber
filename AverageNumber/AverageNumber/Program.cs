namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers:");

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            string inputThree = Console.ReadLine();
            string inputFour = Console.ReadLine();

            int intInputOne;
            int intInputTwo;
            int intInputThree;
            int intInputFour;
            

            bool parsedInputOne = int.TryParse(inputOne, out intInputOne);
            bool parsedInputTwo = int.TryParse(inputTwo, out intInputTwo);
            bool parsedInputThree = int.TryParse(inputThree, out intInputThree);
            bool parsedInputFour = int.TryParse(inputFour, out intInputFour);

            double result = Convert.ToDouble(intInputOne + intInputTwo + intInputThree + intInputFour) / 4;

            Console.WriteLine($"The average of {intInputOne} {intInputTwo} {intInputThree} {intInputFour} is: {result}");

        }
    }
}