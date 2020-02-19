using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Utilities.Mapping.Base
{
    public interface IMapperFacade
    {
        TOutput Map<TInput, TOutput>(TInput input);
        TOutput CreateMapAndMap<TInput, TOutput>(TInput input);
    }

    public  class AutomapperFacade : IMapperFacade
    {
       public  TOutput Map<TInput, TOutput>(TInput input)
        { 
            return Mapper.Map<TInput, TOutput>(input);
        }

        public TOutput CreateMapAndMap<TInput, TOutput>(TInput input)
        {
              Mapper.CreateMap<TInput, TOutput>().ReverseMap();
            return Mapper.Map<TInput, TOutput>(input);
        }
    }


}
