// menyesuaikan assembly dari path folder nya yakni OrderTrack/utils
namespace OrderTrack.utils
{
    public interface INavigableUserControl // interface class untuk inisiasi tipe class 
                                           // saat di MainView
    {
        // atribut class dengan tipe data eventhandler yang menerima sebuah parameter <TEventArgs>
        // dalam hal ini adalah NavigationEventArgs dengan event sebagai penanda untuk publisher
        event EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
    }
}
