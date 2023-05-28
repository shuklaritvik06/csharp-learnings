namespace learnings;

public class Oops
{
    private int _b;
    private int _a;
    public static int Max = 43;
    protected static int Min = 4;
    protected Oops(){}
    public Oops(int a, int b)
    {
        A = a;
        _b = b;
    }

    public int A
    {
        get => _a;
        set => _a = value;
    }

    public void SetA(int c)
    {
        A = c;
    }
    public void SetB(int d)
    {
        _b = d;
    }
    public int GetA()
    {
        return A;
    }
    public int GetB()
    {
        return _b;
    }
}
