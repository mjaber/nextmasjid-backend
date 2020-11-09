using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using IbnMasjjed.Domain;
using IbnMasjjed.DomainView;

namespace IbnMasjjed.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CityLookup, CityLookupView>();
            CreateMap<CityLookupView, CityLookup>();

            CreateMap<RegionLookup, RegionLookupView>();
            CreateMap<RegionLookupView, RegionLookup>();

            CreateMap<Mosque, MosqueView>();
            CreateMap<MosqueView, Mosque>();

        }
    }
}
