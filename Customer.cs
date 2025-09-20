class Customer
{

    private readonly int _pin;
    public int Pin
    {
        get { return _pin; }
    }

    public int userPinTries = 0;
    public bool userBlocked = false;

    public bool userLoggedIn = false;

    public Customer(int Pin)
    {
        _pin = Pin;
    }


    public bool Auth(int tryPin)
    {
        return _pin == tryPin;
    }
}