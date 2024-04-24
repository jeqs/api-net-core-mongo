using Mongo.Application.Common.Responses;
using MediatR;
using System.Collections.Generic;

namespace Mongo.Application.ARS.Queries
{
    public class GetAllARSQuery : IRequest<Response<List<ARSResponse>>>
    {
    }
}
