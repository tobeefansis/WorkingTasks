using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class DataBase
    {
        public int maxCount;
        public List<Player> players = new List<Player>();

        public DataBase(int maxCount)
        {
            this.maxCount = maxCount;
        }

        public void AddPlayers(params Player[] player)
        {
            foreach (var item in player)
            {
                AddPlayer(item);
            }
        }

        void AddPlayer(Player player)
        {
            if (players.Count < maxCount && !IsNickNameExists(player.Name))
            {
                players.Add(player);
            }
            else
            {
                Console.WriteLine($"Такой ник уже есть или не хватает места- {player.Name}");
            }
        }

        bool IsNickNameExists(string nickname)
        {
            return players.Where(n => n.Name == nickname).ToList().Count != 0;
        }
    }
}
