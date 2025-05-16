namespace adapter_dp
{
    public interface IAmericanPlug
    {
        void Plugin();
    }

    public class IndonesianPlug
    {
        public void Sambungkan()
        {
            Console.WriteLine("Colokan indonesia tersambung");
        }
    }

    public class PlugAdaptor : IAmericanPlug
    {
        private readonly IndonesianPlug _plug;

        public PlugAdaptor(IndonesianPlug indonesiaplug) 
        {
            _plug = indonesiaplug;
        }

        public void Plugin() 
        {
            Console.WriteLine("Menggunakan adapter colokan indonesia ke amerika");
            _plug.Sambungkan();
        }
    }

}
