namespace c_sharp_fundamentals;

class CarTwo
{
    private string name;
    public string make;
    public int hp;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public CarTwo(string nameParam, string makeParam, int hpParam)
    {
        Name = nameParam;
        make = makeParam;
        hp = hpParam;
    }

    public void carFunc()
    {
        Console.WriteLine($"Your car is a {Name} {make} with {hp} horse power!");
    }
}