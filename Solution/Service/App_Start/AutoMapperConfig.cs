﻿using System;
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
                .ForMember(y => y.Numero_persona, x => x.MapFrom(src => src.PersonNumber))
                .ForMember(y => y.Contraseña, x => x.MapFrom(src => src.Password))
                .ForMember(y => y.Estatus, x => x.MapFrom(src => src.Status))
                .ForPath(y => y.Persona.Nombre_Completo, x => x.MapFrom(src => src.FullName))
                .ForPath(y => y.Persona.Numero_Empresa, x => x.MapFrom(src => src.CompanyNumber))
                .ForPath(y => y.Persona.Nombre_Corto, x => x.MapFrom(src => src.ShortName))
                .ForPath(y => y.Persona.correo_electronico, x => x.MapFrom(src => src.Email))
                .ReverseMap();
                
            });

            //Mapper.Initialize((config) =>
            //{
            //    config.CreateMap<UsuarioDTO, Usuario>().ReverseMap();
            //});
        }
    }
}