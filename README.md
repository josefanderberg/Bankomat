
This project is a simple command-line ATM application written in C#.

---
I've used encapsulation to protect and control access to data. By making the _balance field in BankAccount.cs private, I've hide its internal state from the rest of the program.
---

Features
The ATM application includes the following features:

User Authentication: Users must enter a correct PIN to access their account.

Deposit: Users can deposit funds into their account.

Withdrawal: Users can withdraw funds, but only if they have a sufficient balance.

Balance Check: Users can view their current account balance.

PIN Tries: The system blocks the user after three failed PIN attempts.

Prerequisites
To run this application, you need to have the following installed:

.NET SDK (version 6.0 or later)

Getting Started
1. Clone the repository
Bash

git clone <repository-url>
2. Navigate to the project directory
Bash

cd <project-directory>
3. Run the application
Bash

dotnet run
Project Structure
Program.cs: The main entry point of the application. It handles user input, menu navigation, and the core logic for the ATM's functionality.

BankAccount.cs: Defines the BankAccount class, which manages the account balance and includes methods for depositing, withdrawing, and checking the balance.

Customer.cs: Defines the Customer class, which handles user authentication, PIN management, and login status.

Person.cs: Defines the Person class, which holds personal information such as the user's name and personal ID.

Customization
Change the initial user data: You can modify the Main method in Program.cs to change the default user's name, personal ID, and PIN.

C#

// Example
var person = new Person("Josef", "930323");
var account = new BankAccount();
var customer = new Customer(1234);
License
This project is licensed under the MIT License.