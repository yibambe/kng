using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Common.DTO;
using Persistance.DatabaseContext;

namespace Service
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UsuarioDTO, Usuario>()
                .ForMember(y => y.Numero_persona, x=> x.MapFrom( src => src.PersonNumber))
                .ForMember(y=> y.Contraseña , x=> x.MapFrom( src => src.Password))
                .ForMember(y => y.Estatus, x => x.MapFrom(src => src.Status)).ReverseMap();
            });

            //Mapper.Initialize((config) =>
            //{
            //    config.CreateMap<UsuarioDTO, Usuario>().ReverseMap();
            //});
        }
    }
}