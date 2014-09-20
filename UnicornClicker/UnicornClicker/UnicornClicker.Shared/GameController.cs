using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;

namespace UnicornClicker
{
    public class GameController
    {
        private static readonly int _gameTime = 5;
        private int _clickCount;
        private int _secondsPlayed;
        private bool _playing;
        private DispatcherTimer _timer;

        public Action<string> DisplayClickCount { get; set; }
        public Action<string> DisplayCountdown { get; set; }
        public Action<string> DisplayTimeLeft { get; set; }
        public Action UpdateUIForGameStarted { get; set; }
        public Action UpdateUIForGameEnded { get; set; }

        public void StartNewGame()
        {
            _clickCount = 0;
            _secondsPlayed = -3;

            DisplayClickCount("0");
            DisplayCountdown("3");
            DisplayTimeLeft(_gameTime.ToString());

            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += HandleTimerTick;

            _timer.Start();

            UpdateUIForGameStarted();
        }

        public void HandleClick()
        {
            if (_playing)
            {
                _clickCount++;
                DisplayClickCount(_clickCount.ToString());
            }
        }

        private void EndGame()
        {
            _timer.Stop();
            _playing = false;
            DisplayTimeLeft("0");

            GameService.RecordGame(_gameTime, _clickCount);

            UpdateUIForGameEnded();
        }

        private void HandleTimerTick(object sender, object e)
        {
            _secondsPlayed++;

            if (_secondsPlayed >= 0 && _secondsPlayed < _gameTime)
            {
                _playing = true;
                DisplayCountdown("");
                DisplayTimeLeft((_gameTime - _secondsPlayed).ToString());
            }
            if (_secondsPlayed >= _gameTime)
            {
                EndGame();
            }
            else if (_secondsPlayed < 0)
            {
                DisplayCountdown((_secondsPlayed * -1).ToString());
            }
        }
    }
}
