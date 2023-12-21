using System;
using System.Transactions;
public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setName(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastNum(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options....");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much do you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("ThankYou for banking with us.  Your new balance is: " + currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much do you like to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());

            //check if user have enough money
            if (currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("Insufficient balance :( ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You're goog to go thankyou");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("445487586", 1236, "Alice", "Magar", 155230.5));
        cardHolders.Add(new cardHolder("445459654", 0032, "Nima", "Rumba", 2562));
        cardHolders.Add(new cardHolder("896521356", 7536, "Doja", "Cat", 122));
        cardHolders.Add(new cardHolder("986571315", 5533, "The", "Weekend", 150));
        cardHolders.Add(new cardHolder("123658415", 4586, "LanaDel", "Ray", 75000));
        cardHolders.Add(new cardHolder("135985315", 3568, "Bruno", "Mars", 587));

        //prompt user
        Console.WriteLine("Welcome to simple ATM");
        Console.WriteLine("Please insert your debit card");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against out db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else { Console.WriteLine("Card not recognized"); }

            }
            catch { Console.WriteLine("Card not recognized. Try again!!!"); }
        }
        Console.WriteLine("Please enter your pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                //check against out db
                if (currentUser.getPin() == userPin)
                {
                    break;
                }
                else { Console.WriteLine("Incorrect Pin. Please try again"); }

            }
            catch { Console.WriteLine("Incorrect Pin. Please try again"); }
        }

        Console.WriteLine("Welcome " +currentUser.getFirstName() + ":)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank You :)");
    }

}