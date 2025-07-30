using Microsoft.AspNetCore.Identity;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _moviecontext;
        private readonly UserManager<AppUser> _userManager;

        public CreateUserRegisterCommandHandler(MovieContext moviecontext, UserManager<AppUser> userManager)
        {
            _moviecontext = moviecontext;
            _userManager = userManager;
        }

        public async Task Handle(CreateUserRegisterCommand command)
        {
            var user = new AppUser()
            {
                Name = command.Name,
                Surname = command.Surname,
                UserName = command.UserName,
                Email = command.Email
            };
            await _userManager.CreateAsync(user, command.Password);
        }
    }
}
