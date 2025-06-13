using tpmodul5_2311104046;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("TULUSSS");

        DataGeneric<string> data = new DataGeneric<string>("2311104046");
        data.PrintData();
    }
}