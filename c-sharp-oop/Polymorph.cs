namespace c_sharp_fundamentals;

public class Animal
{
    public string[] array = { "zebra", "domestic" };

    public virtual void animalSound()
    {
        Console.WriteLine("This animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("This animal barks! Woof woof!");
    }
}

public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("This animal meows! meow meow!");
    }

    public void catBehaviour()
    {
        Console.WriteLine($"This cat is also a {array[0]}");
    }
}