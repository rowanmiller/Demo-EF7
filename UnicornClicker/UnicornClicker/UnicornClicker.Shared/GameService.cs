using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace UnicornClicker
{
    public class GameService
    {
        public static void RecordGame(int duration, int clicks)
        {
            var game = new Game
            {
                Duration = duration,
                Clicks = clicks,
                ClicksPerSecond = (double)clicks / duration,
                Played = DateTime.Now
            };

            using (var db = new GameContext())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public static IEnumerable<Game> GetTopGames()
        {
            using (var db = new GameContext())
            {
                var topGames = db.Games
                    .OrderByDescending(g => g.ClicksPerSecond)
                    .Take(3);

                return topGames;
            }
        }
    }
}
