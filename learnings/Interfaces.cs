namespace learnings;

interface IAnimal 
{
    void AnimalSound();
}

interface IHuman
{
    void Walk();
}

public class Interfaces: IAnimal, IHuman
{
    public void AnimalSound()
    {
        Console.Write("Meow");
    }

    public void Walk()
    {
        Console.Write("Walking");
    }
}