using AutoMapper;
using Mongo.Application.Common.Responses;

namespace Mongo.Application.Common.Mapper
{
    public class MongoMappingProfile : Profile
    {
        public MongoMappingProfile()
        {
            CreateMap<Core.Entities.ARS, ARSResponse>().ReverseMap();
            CreateMap<Core.Entities.LANE, LANEResponse>().ReverseMap();
        }
    }
}
