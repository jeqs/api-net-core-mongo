using Mongo.Application.ARS.Queries;
using Mongo.Application.Common.Constant;
using Mongo.Application.Common.Mapper;
using Mongo.Application.Common.Responses;
using Mongo.Infrastructure.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mongo.Application.ARS.Handlers.QueryHandlers
{
    public class GetAllARSHandler : IRequestHandler<GetAllARSQuery, Response<List<ARSResponse>>>
    {
        private readonly ARSService _arsService;

        public GetAllARSHandler(ARSService arsService)
        {
            _arsService = arsService;
        }

        public async Task<Response<List<ARSResponse>>> Handle(GetAllARSQuery request, CancellationToken cancellationToken)
        {
            var response = new Response<List<ARSResponse>>();
            var entity = await _arsService.GetAsync();

            response.Message = entity is null ? Constants.ConsultaARSNoEncontrados : Constants.ConsultaARSOK;
            response.Result = entity is null ? null : MongoMapper.Mapper.Map<List<ARSResponse>>(entity);

            return response;
        }

    }
}
