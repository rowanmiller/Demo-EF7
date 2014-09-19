using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace UnicornClicker
{
    public sealed partial class GamePage : Page
    {
        private static readonly int _gameTime = 5;
        private int _clickCount;
        private int _secondsPlayed;
        private bool _playing;
        private DispatcherTimer _timer;

        public GamePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            StartNewGame();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (_playing)
            {
                _clickCount++;
                this.ClickCount.Text = _clickCount.ToString();
            }
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Retry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            _clickCount = 0;
            _secondsPlayed = -3;

            this.ClickCount.Text = "0";
            this.Countdown.Text = "3";
            this.Time.Text = _gameTime.ToString();

            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += HandleTimerTick;

            _timer.Start();

            this.Navigation.Visibility = Visibility.Collapsed;
        }

        private void EndGame()
        {
            _timer.Stop();
            _playing = false;
            this.Time.Text = "0";

            GameService.RecordGame(_gameTime, _clickCount);

            this.Navigation.Visibility = Visibility.Visible;
        }

        void HandleTimerTick(object sender, object e)
        {
            _secondsPlayed++;

            if (_secondsPlayed >= 0 && _secondsPlayed < _gameTime)
            {
                _playing = true;
                this.Countdown.Text = "";
                this.Time.Text = (_gameTime - _secondsPlayed).ToString();
            }
            if (_secondsPlayed >= _gameTime)
            {
                EndGame();
            }
            else if (_secondsPlayed < 0)
            {
                this.Countdown.Text = (_secondsPlayed * -1).ToString();
            }
        }
    }
}
