using CarRental.Application.Features.CQRS.Queries.AboutQueries;
using CarRental.Application.Features.CQRS.Results.AboutResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;

namespace CarRental.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutByIdQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var about = await _repository.GetByIdAsync(query.Id);
        return new GetAboutByIdQueryResult
        {
            AboutID = about.AboutID,
            Description = about.Description,
            ImageUrl = about.ImageUrl,
            Title = about.Title
        };
    }
}
