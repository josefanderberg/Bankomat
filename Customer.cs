class Customer
{

    private readonly int pin;
    public int Pin
    {
        get { return pin; }
    }

    public int userPinTries = 0;
    public bool userBlocked = false;

    public bool userLoggedIn = false;

    public Customer(int Pin)
    {
        pin = Pin;
    }


    public bool Auth(int tryPin)
    {
        return pin == tryPin;
    }
}