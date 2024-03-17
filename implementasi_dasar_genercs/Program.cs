using System.Reflection;

public class HaloGeneric
{
    public void SapaUser<T>(T inputUser)
    {
        Console.WriteLine($"Halo user {inputUser}");
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
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
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

        DataGeneric<int> dataNIM = new DataGeneric<int>(1302223041);
        dataNIM.PrintData();
    }
}