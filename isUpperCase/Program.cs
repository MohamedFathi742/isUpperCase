namespace isUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // welcome to user 
            Console.WriteLine("welcome to is Upper Case app");
            // ask user to enter char
            Console.WriteLine("please enter charcter ");
            // read char
            char cValue = 'm';
            bool isConverted = char.TryParse(Console.ReadLine(), out cValue);
            //if
            if (!isConverted)
            {
                Console.WriteLine("Enter corected value");
                return;
            }


            else if (char.IsUpper(cValue))
            {
                Console.WriteLine(" is Upper Case");
            }

            else
            {
                Console.WriteLine(" is lower Case");

            }

        }
    }
}
