using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.MaterialTypes
{
    public class MaterialTypeMapperProfile : Profile
    {
        public MaterialTypeMapperProfile() 
        {
            CreateMap<MaterialType, MaterialTypeDto>();
        }


    }
}
