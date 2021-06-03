using AutoMapper;
using BLL.DTOs.Project;
using BLL.DTOs.User;
using DAL.Entities;

namespace BLL.Infrastructure
{
    public class BllAutoMapperProfiles : Profile
    {
        public BllAutoMapperProfiles()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, RegistrationDto>().ReverseMap();
        }
    }
}