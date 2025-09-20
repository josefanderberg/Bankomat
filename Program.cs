using System;

class Program
{
    static void Main(string[] arg)
    {

    var person = new Person("Josef", "930323");
    var account = new BankAccount();
    var customer = new Customer(1234);

        //Pin
        while (customer.userLoggedIn == false)
        {
            Console.Clear();
            Console.WriteLine("===== ATM =====");
            Console.WriteLine("Enter your pin:");

            if (int.TryParse(Console.ReadLine(), out int tryPin)
            && customer.Auth(tryPin))
            {
                customer.userLoggedIn = true;
                customer.userPinTries = 0;

                Console.WriteLine($"Welcome, {person.Name}!");
                Console.Write("GO TO MENU =>");
                Console.ReadLine();
                break;
            }
            else
            {
                customer.userPinTries++;
                Console.WriteLine($"Wrong Password! You've used {customer.userPinTries} of 3 attemts");
                Console.ReadLine();
                if (customer.userPinTries == 3)
                {
                    customer.userBlocked = true;
                    Console.WriteLine("You are blocked. Contact you bank!");
                    Console.ReadLine();
                    break;
                }

            }
        }

        //Menu
        while (customer.userLoggedIn)
        {
            Console.Clear();
            Console.WriteLine("===== ATM =====");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Saldo");
            Console.WriteLine("4. Quit");

            if (int.TryParse(Console.ReadLine(), out int selectionMenu))
            {
                switch (selectionMenu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("==== DEPOSIT ====");
                            Console.Write("VALUE: ");

                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                if (amount <= 0)
                                {
                                    Console.WriteLine("It has to be more than 0");
                                }
                                account.Deposit(amount);
                                Console.WriteLine($"You successfully deposit: {amount} kr");
                                Console.WriteLine($"You got {account.Balance} kr");
                                Console.Write("GO TO MENU =>");
                                Console.ReadLine();
                            }

                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("=== WITHDRAW ===");
                            Console.Write("> ");
                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                if (amount > account.Balance)
                                {
                                    Console.WriteLine("You don't have enough money");
                                }
                                else if (amount <= 0)
                                {
                                    Console.WriteLine("It has to be more than 0");
                                }
                                else
                                    account.Withdraw(amount);
                                Console.WriteLine($"You successfully withdraw: {amount} kr");
                                Console.WriteLine($"You got {account.Balance} kr");
                                Console.Write("GO TO MENU =>");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("=== SHOW SALDO ===");
                            Console.WriteLine($"You got: {account.Balance} kr");
                            Console.Write("GO TO MENU =>");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            customer.userLoggedIn = false;
                            Console.Clear();
                            Console.WriteLine("You are logged out");
                            Console.ReadLine();
                        }
                        return;
                    default:
                        {
                            Console.WriteLine("Wrong input, try again!");
                            Console.ReadLine();
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
                Console.ReadLine();
            }
        }
      }
}