using AutoMapper;
using System;

namespace Mimir.Server.Endpoint
{
    public class BaseHandler
    {
        protected readonly IMapper _mapper;

        protected BaseHandler(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}