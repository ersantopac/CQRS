﻿using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Claims.Rules
{
    public class OperationClaimBusinessRules
    {
        private readonly IOperationClaimRepository _operationClaimRepository;

        public OperationClaimBusinessRules(IOperationClaimRepository operationClaimRepository)
        {
            _operationClaimRepository = operationClaimRepository;
        }

        public async Task ClaimNameCanNotBeDublicateWhenInserted(string name)
        {
            IPaginate<OperationClaim> result=await _operationClaimRepository.GetListAsync(c=>c.Name==name);
            if (result.Items.Any()) throw new BusinessException("Claim name exists");
            
        }

        public void ClaimShouldExistsWhenRequested(OperationClaim claim)
        {
            if (claim == null) throw new BusinessException("Operation Claim Name Does not exist");
            
        }
    }
}
