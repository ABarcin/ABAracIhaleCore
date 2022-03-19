using AB_AracIhaleCore.DAL.Dtos;
using AB_AracIhaleCore.DAL.Enums;
using AB_AracIhaleCore.MODEL.Entities;
using AutoMapper;

namespace AB_AracIhaleCore.DAL.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<AracTramer, AracTramerDTO>();
            CreateMap<AracTramerDTO, AracTramer>();
            
            CreateMap<AracTramerDetay, AracTramerDetayDTO>()
                .ForMember(dest => dest.ParcaAdi, opt => opt.MapFrom(src => (ParcaEnum)src.AracParcaId))
                .ForMember(dest => dest.TramerDurum, opt => opt.MapFrom(src => (TramerEnum)src.AracTramerDetayId));
            CreateMap<Ihale, IhaleDTO>();
            CreateMap<IhaleDTO, Ihale>();
        }
    }
}
