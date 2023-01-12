using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Ranking
    {
        public static List<Player> _playersRankList= new List<Player>();

        public static void checkExistence(Player player)
        {
            int index = _playersRankList.FindIndex(ranking => ranking.Name == player.Name);
            if (index != -1)
            {
                _playersRankList[index].Score += player.Score;
            }
            else
            {
                _playersRankList.Add(player);
            }
        }

        public static void checkPoints()
        {
            foreach (var item in _playersRankList)
            {
                Console.WriteLine(item.Name + ", " + item.Score);
            }
        }
    }
}
