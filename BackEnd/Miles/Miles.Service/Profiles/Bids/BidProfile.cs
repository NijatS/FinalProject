using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Bids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Bids
{
    public class BidProfile:Profile
    {
        public BidProfile()
        {
			CreateMap<BidPostDto, Bid>();
        }
    }
}
