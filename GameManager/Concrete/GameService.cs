using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    public class GameService : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+" Added!");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Name + " Removed!");
        }

        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name+" pursched by "+gamer.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Updated!");
        }
    }
}
