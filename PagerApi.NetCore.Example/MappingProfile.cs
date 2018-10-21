using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagerApi.NetCore.Example
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TestDTO, DB.Test>();
            CreateMap<DB.Test, TestDTO>();
        }
    }
}
