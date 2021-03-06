﻿using Armut.Api.Core.Entities;
using Armut.Api.Core.Models;
using AutoMapper;

namespace Armut.Api.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddUserModel, UserModel>().ReverseMap();
            CreateMap<AddJobModel, JobModel>().ReverseMap();
            CreateMap<AddProviderModel, ProviderModel>().ReverseMap();
            CreateMap<AddJobQuoteModel, JobQuoteModel>().ReverseMap();

            CreateMap<AddJobQuoteViewModel, AddJobQuoteModel>();
            CreateMap<AddUserViewModel, AddUserModel>();

            CreateMap<UserEntity, UserModel>().ReverseMap();
            CreateMap<JobEntity, JobModel>().ReverseMap();
            CreateMap<ProviderEntity, ProviderModel>().ReverseMap();
            CreateMap<JobQuoteEntity, JobQuoteModel>().ReverseMap();
            CreateMap<ServiceEntity, ServiceModel>().ReverseMap();

            CreateMap<AddUserModel, UserEntity>();
            CreateMap<AddJobModel, JobEntity>();
            CreateMap<AddProviderModel, ProviderEntity>();
            CreateMap<AddJobQuoteModel, JobQuoteEntity>();
        }
    }
}
