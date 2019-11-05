using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blyat23
{
   
         class PathToPicture
        {
            public Player[] players = new Player[3];
            public Picture[] picture = new Picture[3];
            public Dictionary<Player, Picture> keyValuePairs = new Dictionary<Player, Picture>();

            public PathToPicture(Player[] player, Picture[] pictures)
            {
                this.players = player;
                this.picture = pictures;
            }

            public void InitlizeEverything()
            {

                for (int i = 0; i < 3; i++)
                {
                    keyValuePairs.Add(players[i], picture[i]);
                }
            }
        }
    
}
