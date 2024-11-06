namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Console.Write("Enter the first number : ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            int result = numberOne + NumberTwo;
            Console.WriteLine($"{numberOne} + {NumberTwo} = {result}");

            result = numberOne - NumberTwo;
            Console.WriteLine($"{numberOne} - {NumberTwo} = {result}");

            result = numberOne * NumberTwo;
            Console.WriteLine($"{numberOne} * {NumberTwo} = {result}");

            float resultDivision = numberOne / (float)NumberTwo;
            Console.WriteLine($"{numberOne} / {NumberTwo} = {resultDivision}");
            #endregion Question 1

            #region Question 2
              Console.WriteLine("Enter first Name: ");
              string FirstName = Console.ReadLine();
              Console.WriteLine("Enter Last Name: ");
              string LastName  = Console.ReadLine();
              Console.WriteLine($"Full Name: {FirstName +" " + LastName}");
            #endregion Question 2

        }
    }
}
