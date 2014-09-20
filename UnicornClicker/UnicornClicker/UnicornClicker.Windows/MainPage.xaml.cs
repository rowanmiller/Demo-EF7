using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UnicornClicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private GameController _gameController;

        public MainPage()
        {
            this.InitializeComponent();

            _gameController = new GameController
            {
                DisplayClickCount = (s) => this.ClickCount.Text = s,
                DisplayCountdown = (s) => this.Countdown.Text = s,
                DisplayTimeLeft = (s) => this.Time.Text = s,
                UpdateUIForGameStarted = () => this.Play.Visibility = Visibility.Collapsed,
                UpdateUIForGameEnded = () =>
                {
                    this.Play.Visibility = Visibility.Visible;
                    LoadHistory();
                }
            };
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadHistory();
        }

        private void Play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _gameController.StartNewGame();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _gameController.HandleClick();
        }

        private void LoadHistory()
        {
            this.GameList.ItemsSource = GameService.GetTopGames();
        }
    }
}
