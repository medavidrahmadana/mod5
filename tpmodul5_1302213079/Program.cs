public class HaloGeneric
{
    public void SapaUser<D>(D user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric hg = new HaloGeneric();
        hg.SapaUser("David");
    }
}
