using AutoMapper;
using LEARN1.Application.ViewModels;
using LEARN1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() 
        {
            CreateMap<ClewViewModel, Clew>();
        }
    }
}
