using AutoMapper;
using BLL.DTOs.Project;
using BLL.DTOs.User;
using DAL.Entities;

namespace BLL.Injections
{
    public class BllAutoMapperProfiles : Profile
    {
        public BllAutoMapperProfiles()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Project, ProjectCreateDto>().ReverseMap();
            
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, RegistrationDto>().ReverseMap();
        }
    }
}