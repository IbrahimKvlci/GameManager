using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    public class GamerManager : IGamerManager
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamer(gamer))
            {
                Console.WriteLine("Saved! " + gamer.Name);
            }
            else
            {
                Console.WriteLine("Gamer not a valid!");
            }
        }
    }
}
