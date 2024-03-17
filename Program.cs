internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric user = new HaloGeneric();
        user.sapaUser<string>("Joshua");
    }
}

public class HaloGeneric
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}