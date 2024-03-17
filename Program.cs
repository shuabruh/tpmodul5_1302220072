internal class Program
{
    private static void Main(string[] args)
    {
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