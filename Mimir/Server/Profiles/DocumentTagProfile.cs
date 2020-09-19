using AutoMapper;
using Mimir.Domain.Models;
using Mimir.Server.Controllers;
using Mimir.Shared.Models;

namespace Mimir.Server.Profiles
{
    public class DocumentTagProfile : Profile
    {
        public DocumentTagProfile()
        {
            CreateMap< DocumentTag, DocumentTagGetResponse>();
        }
    }
}