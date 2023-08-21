using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Comments
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
			CreateMap<CommentPostDto, Comment>();
        }
    }
}
