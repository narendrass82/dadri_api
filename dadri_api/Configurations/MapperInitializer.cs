using AutoMapper;
using dadri_api.Data;
using dadri_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
            CreateMap<UserRegister, UserRegisterDTO>().ReverseMap();
            CreateMap<UserRegister,UserRegisterCreateDTO>().ReverseMap();            
            CreateMap<ApiUser, UserDTO>().ReverseMap();
            CreateMap<UsersApproveResgister, UsersApproveResgisterDTO>().ReverseMap();
        }
    }
}
