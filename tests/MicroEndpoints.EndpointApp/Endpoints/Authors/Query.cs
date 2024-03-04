using AutoMapper;
using MicroEndpoints.Attributes;
using MicroEndpoints.EndpointApp.DomainModel;
using MicroEndpoints.FluentGenerics;
using Microsoft.AspNetCore.Mvc;

namespace MicroEndpoints.EndpointApp.Endpoints.Authors;

public class Query : EndpointBaseAsync
      .WithQuery<int, int>
      .WithResult<Author>
{
    private IAsyncRepository<Author> _repository;
    private IMapper _mapper;

    public Query(IAsyncRepository<Author> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [Get("api/authors/query")]
    public override Task<Author> HandleAsync([FromServices] IServiceProvider serviceProvider,
        int page,
        int pageSize, CancellationToken cancellationToken = default) =>
        _repository.GetByIdAsync(1, cancellationToken);
}
