using CarRental.Application.Features.CQRS.Results.AboutResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;

namespace CarRental.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetAboutQueryResult>> Handle()
    {
        var abouts = await _repository.GetAllAsync();
        return abouts.Select(x => new GetAboutQueryResult
        {
            AboutID = x.AboutID,
            Description = x.Description,
            Title = x.Title,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}
