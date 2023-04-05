﻿using Application.Features.Technologies.Dtos;
using Application.Features.Technologies.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Technology,TechnologyListDto>().ForMember(c=>c.LanguageName,opt=>opt.MapFrom(c=>c.Language.Name)).ReverseMap();
            CreateMap<IPaginate<Technology>, TechnologyListModel>().ReverseMap();
            
        }
    }
}
