using CarRental.Application.Features.CQRS.Commands.AboutCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;

namespace CarRental.Application.Features.CQRS.Handlers.AboutHandlers;

public class UpdateAboutCommandHandler
{
    private readonly IRepository<About> _repository;
    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateAboutCommand command)
    {
        var about = await _repository.GetByIdAsync(command.AboutID);
        about.Description = command.Description;
        about.Title = command.Title;
        about.ImageUrl = command.ImageUrl;
        await _repository.UpdateAsync(about);
    }
}
