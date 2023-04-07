﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Claims.Commands.CreateOperationClaim
{
    public class CreateOperationClaimCommandValidator:AbstractValidator<CreateOperationClaimCommand>
    {
        public CreateOperationClaimCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
