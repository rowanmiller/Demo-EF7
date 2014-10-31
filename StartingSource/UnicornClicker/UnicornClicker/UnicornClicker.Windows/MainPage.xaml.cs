using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace UnicornClicker
{
    public sealed partial class MainPage : Page
    {
        private GameViewModel _game;

        public MainPage()
        {
            this.InitializeComponent();

            _game = new GameViewModel();

            // Refresh scores after each game completes
            _game.GameCompleted += (s) =>
            {
                ReloadHistory();
            };

            this.GamePane.DataContext = _game;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadHistory();
        }

        private void Play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _game.StartNewGame();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _game.HandleClick();
        }

        private void ReloadHistory()
        {
            this.GameList.ItemsSource = GameService.GetTopGames();
        }
    }
}
