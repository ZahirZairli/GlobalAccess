using MediatR;
using PresentationLayer.CQRS.Results.GuideResults;
using System.Collections.Generic;

namespace PresentationLayer.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
