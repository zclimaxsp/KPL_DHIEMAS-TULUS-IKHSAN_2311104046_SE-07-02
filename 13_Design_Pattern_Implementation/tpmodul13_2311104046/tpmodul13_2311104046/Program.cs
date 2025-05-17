using System;

class Program
{
    static void Main(string[] args)
    {
        // Buat subject (pengirim notifikasi)
        Subject weatherStation = new Subject();

        // Buat observer (penerima notifikasi)
        Observer user1 = new Observer("Dhiemas");
        Observer user2 = new Observer("Eva");

        // Daftarkan observer ke subject
        weatherStation.Attach(user1);
        weatherStation.Attach(user2);

        // Buat pesan
        weatherStation.CreateMessage("Cuaca Hari Ini: Cerah");

        // Lepaskan 1 observer
        weatherStation.Detach(user1);

        // Kirim pesan lagi
        weatherStation.CreateMessage("Cuaca Besok: Hujan");
    }
}
