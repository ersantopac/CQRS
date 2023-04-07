using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auts.Rules
{
    public class AuthBusinessRules
    {
        private readonly IUserRepository _useRepository;

        public AuthBusinessRules(IUserRepository useRepository)
        {
            _useRepository = useRepository;
        }

        public async Task EmailCanNotBeDuplicatedWhenRegistered(string email)
        {
            User? user = await _useRepository.GetAsync(u => u.Email == email);
            if (user != null) throw new BusinessException("Mail already exists");
        }
    }
}
