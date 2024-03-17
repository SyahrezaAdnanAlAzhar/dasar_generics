public class HaloGeneric
{
    public void SapaUser<T>(T inputUser)
    {
        Console.WriteLine($"Halo user {inputUser}");
    }
}

public class main
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan nama anda: ");
        String inputUser = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(inputUser);
    }
}