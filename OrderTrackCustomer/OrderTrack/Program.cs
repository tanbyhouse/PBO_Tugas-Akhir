using OrderTrack.view; // Baris 1: Directive 'using'

namespace OrderTrack // Baris 3: Deklarasi Namespace
{
    internal static class Program // Baris 5: Deklarasi Kelas 'Program'
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread] // Baris 9: Atribut STAThread
        static void Main() // Baris 10: Deklarasi Metode 'Main'
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize(); // Baris 14: Pemanggilan Metode
            Application.Run(new MainView()); // Baris 15: Pemanggilan Metode dan Instansiasi Objek
        } 
    }
}