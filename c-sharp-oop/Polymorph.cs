namespace c_sharp_fundamentals;

public class Animal
{
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
}