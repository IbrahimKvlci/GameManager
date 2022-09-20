using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    internal class GamerCheckManager : IGamerCheckService
    {
        public bool CheckGamer(Gamer gamer)
        {
            return true;
        }
    }
}
