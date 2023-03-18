public class HaloGeneric
{
    public void SapaUser<D>(D user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}


class Program
{
    static void Main(string[] args)
    {
        HaloGeneric haloG = new HaloGeneric();
        haloG.SapaUser("David");
        DataGeneric<string> dataG = new DataGeneric<string>("1302213079");
        dataG.PrintData();
    }
}
