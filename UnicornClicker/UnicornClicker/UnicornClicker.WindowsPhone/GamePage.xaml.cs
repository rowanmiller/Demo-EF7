using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace UnicornClicker
{
    public sealed partial class GamePage : Page
    {
        private GameViewModel _game;

        public GamePage()
        {
            this.InitializeComponent();

            _game = new GameViewModel();
            this.DataContext = _game;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _game.StartNewGame();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _game.HandleClick();
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Retry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _game.StartNewGame();
        }
    }
}
