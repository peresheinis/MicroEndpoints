using AutoMapper;
using MicroEndpoints.Attributes;
using MicroEndpoints.FluentGenerics;
using Microsoft.AspNetCore.Mvc;
using MicroEndpoints.EndpointApp.DomainModel;

namespace MicroEndpoints.EndpointApp.Endpoints.Authors;

public class Query : EndpointBaseAsync
      .WithQuery<int, int>
      .WithIResult
{
    private IAsyncRepository<Author> _repository;
    private IMapper _mapper;

    public Query(IAsyncRepository<Author> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [Get("api/authors/query")]
    public override Task<IResult> Handle(
        int page,
        int pageSize, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
