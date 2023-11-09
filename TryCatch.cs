namespace learnings;

public class TryCatch
{
    public static int Sum(int a, int b)
    {
        try
        {
            return a + b;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return -1;
        }
        finally
        {
            Console.WriteLine("Finally Done!");
        }
    }
}