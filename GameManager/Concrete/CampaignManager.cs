using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Campaig: "+campaign.Name+" added to "+game.Name);
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Campaig: " + campaign.Name + " deleted from " + game.Name);
        }
    }
}
