﻿using AutoMapper;
using MicroEndpoints.Attributes;
using MicroEndpoints.FluentGenerics;
using Microsoft.AspNetCore.Mvc;
using MicroEndpoints.EndpointApp.DomainModel;

namespace MicroEndpoints.EndpointApp.Endpoints.Authors;

public class Get : EndpointBaseAsync
      .WithRequest<int>
      .WithIResult
{
    private IAsyncRepository<Author> _repository;
    private IMapper _mapper;

    public Get(IAsyncRepository<Author> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    /// <summary>
    /// Get a specific Author
    /// </summary>
    [Get("api/authors/{id}")]
    public override async Task<IResult> HandleAsync(
        [FromServices] IServiceProvider serviceProvider,
        int id, CancellationToken cancellationToken = default)
    {
        var author = await _repository.GetByIdAsync(id, cancellationToken);

        if (author is null) return NotFound();

        var result = _mapper.Map<AuthorResult>(author);

        return Ok(result);
    }
}
