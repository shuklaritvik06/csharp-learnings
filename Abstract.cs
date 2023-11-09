namespace learnings;

public abstract class Abstract
{
    public abstract void AbstractMethod();

    public void GreetHello()
    {
        Console.Write("Hello World!");
    }
}

public class Implementation : Abstract
{
    public override void AbstractMethod()
    {
        Console.Write("Hello");
    }
}