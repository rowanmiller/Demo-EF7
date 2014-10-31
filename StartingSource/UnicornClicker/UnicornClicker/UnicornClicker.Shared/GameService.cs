using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace UnicornClicker
{
    public class GameService
    {
        private static List<Game> _games = new List<Game>();

        public static void RecordGame(int duration, int clicks)
        {
            var game = new Game
            {
                Duration = duration,
                Clicks = clicks,
                ClicksPerSecond = (double)clicks / duration,
                Played = DateTime.Now
            };

            _games.Add(game);
        }

        public static IEnumerable<Game> GetTopGames()
        {
                var topGames = _games
                    .OrderByDescending(g => g.ClicksPerSecond)
                    .Take(3);

                return topGames;
        }
    }
}
