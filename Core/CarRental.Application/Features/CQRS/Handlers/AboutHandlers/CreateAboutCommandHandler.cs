﻿using CarRental.Application.Features.CQRS.Commands.AboutCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;

namespace CarRental.Application.Features.CQRS.Handlers.AboutHandlers;

public class CreateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public CreateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateAboutCommand command)
    {
        await _repository.CreateAsync(new About
        {
            Title = command.Title,
            Description = command.Description,
            ImageUrl = command.ImageUrl
        });
    }
}
