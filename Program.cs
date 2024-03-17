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
        DataGeneric<string> genericData = new DataGeneric<string>("1302220072");
        genericData.printData();
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah " + data);
    }
}