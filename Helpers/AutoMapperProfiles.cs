using AutoMapper;
using Backend.DTO;
using Backend.Models;

namespace Backend.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
