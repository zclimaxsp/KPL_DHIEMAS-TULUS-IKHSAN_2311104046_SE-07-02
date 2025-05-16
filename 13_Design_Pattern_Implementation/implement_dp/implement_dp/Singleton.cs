namespace singleton_dp
{
        public class Rektor
        {
            private static Rektor? _instance;

            private Rektor()
                {
                Console.WriteLine("Rektor baru dipilih");
                }

            public static Rektor GetRektor() 
            {
                if (_instance == null) 
                {
                    _instance = new Rektor();
                }
                return _instance;
            }

            public void Tandatangan()
            {
                Console.WriteLine("Rektor telah tanda tangan");
            }
        }
    }

