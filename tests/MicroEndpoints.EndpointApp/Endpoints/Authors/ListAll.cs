using AutoMapper;
using MicroEndpoints.Attributes;
using MicroEndpoints.EndpointApp.DomainModel;
using MicroEndpoints.FluentGenerics;
using Microsoft.AspNetCore.Mvc;

namespace MicroEndpoints.EndpointApp.Endpoints.Authors;

public class ListAll : EndpointBaseAsync
    .WithoutRequest
    .WithResult<IEnumerable<AuthorListResult>>
{
    private IAsyncRepository<Author> _repository;
    private IMapper _mapper;

    public ListAll(IAsyncRepository<Author> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    /// <summary>
    /// List all Authors
    /// </summary>
    [Get("api/authors")]
    public override async Task<IEnumerable<AuthorListResult>> HandleAsync(
        [FromServices] IServiceProvider serviceProvider, CancellationToken cancellationToken = default)
    {
        var result = (await _repository.ListAllAsync(cancellationToken))
            .Select(i => _mapper.Map<AuthorListResult>(i));

        return result;
    }
}
