using System;

class Program
{
    static void Main(string[] arg)
    {

    var person = new Person("Josef", "930323");
    var account = new BankAccount();
    var customer = new Customer(1242, account);


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
                break;
            }
            else
            {
                customer.userPinTries++;
                if (customer.userPinTries == 3)
                {
                    customer.userBlocked = true;
                    break;
                }

            }
        }
//Menu
        while(customer.userLoggedIn)
        {
        Console.Clear();
        Console.WriteLine("===== ATM =====");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Saldo");
                Console.WriteLine("4. Quit");

                if (int.TryParse(Console.ReadLine(), out int selectionMenu))
                  {
                  switch(selectionMenu)
                  {
                        case 1:
                              {
                                    if (int.TryParse(Console.ReadLine(), out int amount)
                                    && amount > 0)
                                    {
                                    account.Deposit(amount);
                                    }

                              }
                              break;
                        case 2:
                              {
                                    if (int.TryParse(Console.ReadLine(), out int amount)
                                    && amount > 0)
                                    {
                                    account.Withdraw(amount);
                                    }
                              }
                              break;
                        case 3:
                              {
                                    account.ShowSaldo();
                              }
                              break;
                        default:
                              {
                                    customer.userLoggedIn = false;
                                    return;
                              }
                        }
                  }                 
            }
      }
}

class Customer
{

      private readonly BankAccount account;

      //Pincode
      private readonly int pin;
      public int Pin
      {
      get { return pin; }
      }

      public int userPinTries = 0;
    public bool userBlocked = false;

    public bool userLoggedIn = false;


    public Customer(int Pin, BankAccount account)
    {
        pin = Pin;
        this.account = account;

    }

      
      public bool Auth(int tryPin)
      {
            return pin == tryPin;    
      }
      
}

class BankAccount
{


      private int balance;
      public int Balance
      {
      get { return balance; }
      set { balance = value; }
      }


      public int Deposit(int amount)
      {
            return Balance += amount;     
      }
      public int Withdraw(int amount)
      {
            return Balance -= amount;     
      }
      public int ShowSaldo()
      {
            return Balance;
      }
}

class Person
{

      private readonly string name;
      private readonly string personalid;
      

      //Name
      public string Name
      {
      get { return name; }
      }

      public string PersonalId
      {
      get { return personalid; }
      }

      public Person(string name, string personalid)
      {
            this.name = name;
            this.personalid = personalid;
      }
}
