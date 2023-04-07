using Application.Features.Claims.Commands.CreateOperationClaim;
using Application.Features.Claims.Dtos;
using Application.Features.Claims.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Claims.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<OperationClaim, CreatedOperationClaimDto>().ReverseMap();
            CreateMap<OperationClaim, CreateOperationClaimCommand>().ReverseMap();

            CreateMap<IPaginate<OperationClaim>,OperationClaimListModel>().ReverseMap();

        }
    }
}
