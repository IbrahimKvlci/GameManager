using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign,Game game);
        void Delete(Campaign campaign, Game game);

    }
}
