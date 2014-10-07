using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Windows.UI.Xaml;

namespace UnicornClicker
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private static readonly int _gameTime = 5;
        private int _clickCount;
        private int _secondsPlayed;
        private bool _playing;
        private DispatcherTimer _timer;
        private Visibility _gameControlsVisibility = Visibility.Visible;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public int ClickCount
        {
            get
            {
                return _clickCount;
            }
            set
            {
                _clickCount = value;
                OnPropertyChanged("ClickCount");
            }
        }

        public int? Countdown
        {
            get
            {
                return _secondsPlayed < 0
                    ? (int?)_secondsPlayed * -1
                    : null;
            }
        }

        public int SecondsRemaining
        {
            get
            {
                return _secondsPlayed >= 0
                    ? _gameTime - _secondsPlayed
                    : _gameTime;
            }
        }

        public int SecondsPlayed
        {
            get
            {
                return _secondsPlayed;
            }
            set
            {
                _secondsPlayed = value;
                OnPropertyChanged("SecondsPlayed");
                OnPropertyChanged("SecondsRemaining");
                OnPropertyChanged("Countdown");
            }
        }

        public Visibility GameControlsVisibility
        {
            get
            {
                return _gameControlsVisibility;
            }
            set
            {
                _gameControlsVisibility = value;
                OnPropertyChanged("GameControlsVisibility");
            }
        }

        public bool Playing
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                OnPropertyChanged("Playing");
            }
        }

        public void StartNewGame()
        {
            ClickCount = 0;
            SecondsPlayed = -3;
            GameControlsVisibility = Visibility.Collapsed;

            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += HandleTimerTick;
            _timer.Start();
        }

        public void HandleClick()
        {
            if (Playing)
            {
                ClickCount++;
            }
        }

        private void HandleTimerTick(object sender, object e)
        {
            SecondsPlayed++;

            if (_secondsPlayed >= _gameTime)
            {
                _timer.Stop();
                Playing = false;

                GameService.RecordGame(_gameTime, _clickCount);

                GameControlsVisibility = Visibility.Visible;
            }
            else if(!_playing && _secondsPlayed >= 0)
            {
                Playing = true;
            }
        }
    }
}
