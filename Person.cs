class Person
{



    //Name
private readonly string name;
public string Name
    {
        get { return name; }
    }

private readonly string personalid;
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
