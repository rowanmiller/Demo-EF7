using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace UnicornClicker
{
    public sealed partial class GamePage : Page
    {
        private GameController _gameController;

        public GamePage()
        {
            this.InitializeComponent();

            _gameController = new GameController
            {
                DisplayClickCount = (s) => this.ClickCount.Text = s,
                DisplayCountdown = (s) => this.Countdown.Text = s,
                DisplayTimeLeft = (s) => this.Time.Text = s,
                UpdateUIForGameStarted = () => this.Navigation.Visibility = Visibility.Collapsed,
                UpdateUIForGameEnded = () => this.Navigation.Visibility = Visibility.Visible
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _gameController.StartNewGame();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _gameController.HandleClick();
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Retry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _gameController.StartNewGame();
        }
    }
}
