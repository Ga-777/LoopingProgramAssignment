namespace LoopingProgramAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Random Number Generator 2.0!");
            Console.WriteLine("This program will generate a random number between two numbers you provide.");
            Console.WriteLine("Please press enter to continue:");
            Console.ReadLine();
            numbers();
            Console.WriteLine("");
            Console.WriteLine("Please press enter to continue:");
            Console.ReadLine();
            BankOfBlorb();
        }
        static void numbers()
        {
            Console.Clear();
            int redo = 1;
            for (int i = 0; i < redo; i++)
            {
                int number, number2;
                Console.WriteLine("Please enter 1th number");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                Console.Clear();
                Console.WriteLine("Please enter 2nd number");
                while (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                Console.Clear();
                if (number > number2)
                {
                    Console.WriteLine("The first number is greater than the second number. Please enter the numbers again.");
                    redo++;
                }
                else if (number == number2)
                {
                    Console.WriteLine("The numbers are equal. Please enter the numbers again.");
                    redo++;
                }
                else if (number < number2)
                {
                    number2 = number2 + 1;
                    Random random = new Random();
                    int randomNumber = random.Next(number, number2);
                    Console.WriteLine("The random number between " + number + " and " + (number2 - 1) + " is: " + randomNumber);
                    redo = 0;
                }
            }





        }
        static void BankOfBlorb()
        {
            int choice ;
            decimal depositAmount, withdrawAmount;
            for (int i = 0; i < 1; i++)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bank of blorb, or BoB");
                Console.WriteLine("Please enter your name:");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome " + name + " to the Bank of blorb, or BoB");
                Console.WriteLine("Please enter your account number:");
                string accountNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome " + name + " to the Bank of blorb, or BoB");
                Console.WriteLine("/////////////////////////////////////////////////");
                Console.WriteLine("Please pick one below: ");
                Console.WriteLine("");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                }
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Your balance is: $150");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the amount you would like to deposit:");
                    while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount greater than 0.");
                    }
                    Console.Clear();
                    Console.WriteLine("You have deposited: $" + depositAmount);
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the amount you would like to withdraw:");
                    while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount greater than 0.");
                    }
                    Console.Clear();
                    Console.WriteLine("You have withdrawn: $" + withdrawAmount);
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Bank of blorb, or BoB");
                    
                }
            }
            

        }
    }
}
