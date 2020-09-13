using AutoMapper;
using Mimir.Domain.Models;
using Mimir.Shared.Models;

namespace Mimir.Server.Profiles
{
    public class DocumentTagProfile : Profile
    {
        public DocumentTagProfile()
        {
            CreateMap<DocumentTagDisplay, DocumentTag>();
        }
    }
}