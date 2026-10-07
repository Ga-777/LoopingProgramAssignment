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
            int choice = 0;
            decimal depositAmount, withdrawAmount, balance = 150, fee = 0.75m, bill = 0, payment = 0;
            Console.Clear();
            Console.WriteLine("Welcome to the Bank of blorb, or BoB");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            while (choice != 5)
            {

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
                Console.WriteLine("4. Bill payment");
                Console.WriteLine("");
                
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.WriteLine("A fee of " + fee.ToString("c") + " will be charged for each transaction.");
                Console.WriteLine("");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
                }
                if (choice == 1)
                {
                    Console.Clear();
                    if (balance > 0)
                    {
                        balance = balance - fee;
                        
                    }
                    else
                    {
                        
                        bill = bill + fee;
                    }

                    Console.WriteLine("Your balance is " + balance.ToString("c"));
                    Console.WriteLine("");

                    Console.WriteLine("Please press enter to continue:");
                    Console.ReadLine();

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
                    Console.WriteLine("You have deposited: " + depositAmount.ToString("c"));
                    balance = balance + depositAmount;
                    if (balance >= 0)
                    {
                        balance = balance - fee;

                    }
                    else
                    {
                        bill = bill + fee;
                    }
                    Console.WriteLine("Your new balance is: " + balance.ToString("c"));
                    Console.WriteLine("");

                    Console.WriteLine("Please press enter to continue:");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the amount you would like to withdraw:");
                    while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount greater than 0.");
                    }
                    if (withdrawAmount > balance)
                    {
                        Console.Clear();
                        Console.WriteLine("You do not have enough funds to withdraw that amount.");
                        Console.WriteLine("Your current balance is: " + balance.ToString("c"));
                        Console.WriteLine("");

                        Console.WriteLine("Please press enter to continue:");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have withdrawn: " + withdrawAmount.ToString("c"));
                        balance = balance - withdrawAmount;
                        if (balance > 0)
                        {
                            balance = balance - fee;
                            
                        }
                        else
                        {
                            bill = bill + fee;
                        }
                        Console.WriteLine("Your new balance is: " + balance.ToString("c"));
                        if (balance <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You don't have enough funds.");
                            balance = 0;
                            Console.WriteLine("Your new balance is: " + balance);
                            bill = bill + fee;

                        }



                        Console.WriteLine("");
                        Console.WriteLine("Please press enter to continue:");
                        Console.ReadLine();
                    }


                }
                if (choice == 4)
                {
                    Console.Clear();
                    if (bill <= 0)
                    {
                        balance = balance - fee;
                        Console.WriteLine("You do not have any bills to pay.");
                        Console.WriteLine("");
                        Console.WriteLine("Please press enter to continue:");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Your current bill is: " + bill.ToString("c"));
                        Console.WriteLine("Please enter the amount you would like to pay for your bill:");
                        while (!decimal.TryParse(Console.ReadLine(), out payment) || payment <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount greater than 0.");
                        }
                        if (payment > balance)
                        {
                            Console.Clear();
                            Console.WriteLine("You do not have enough funds to pay that bill.");
                            bill = bill + fee;
                            if (balance > 0)
                            {
                                balance = balance - fee;
                            }
                            Console.WriteLine("Your current balance is: " + balance.ToString("c"));
                            Console.WriteLine("");

                            Console.WriteLine("Please press enter to continue:");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {


                            balance = balance - fee;
                            Console.Clear();
                            bill = bill - payment;
                            Console.WriteLine("You have paid: " + payment.ToString("c") + " for your bill.");
                            if (bill <= 0)
                            {


                                bill = 0;
                            }

                            Console.WriteLine("Your current bill is: " + (bill).ToString("c"));
                            balance = balance - payment;

                            if (balance > 0)
                            {
                                balance = balance - fee;
                                bill = bill - payment;
                                balance = balance + bill;
                            }
                            Console.WriteLine("Your new balance is: " + balance.ToString("c"));
                            if (balance <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("You don't have enough funds.");
                                balance = 0;
                                Console.WriteLine("Your new balance is: " + balance);
                                bill = bill + fee;

                            }


                        }

                        Console.WriteLine("");
                        Console.WriteLine("Please press enter to continue:");
                        Console.ReadLine();

                    }
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Bank of blorb, or BoB");

                }
            }


        }
    }
}
