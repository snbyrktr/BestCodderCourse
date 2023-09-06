using AutoMapper;
using BestCodder.Common;
using BestCodder.DataAccess.Data;
using BestCodder.Models;

namespace BestCodder.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CourseDto, Course>().ReverseMap()
                          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.CoursePrice, opt => opt.MapFrom(src => src.CoursePrice));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.SubTitle, opt => opt.MapFrom(src => src.SubTitle));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.RegularRate, opt => opt.MapFrom(src => src.RegularRate));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //             .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate));
            //CreateMap<CourseDto, Course>().ReverseMap()
            //            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));





            //CreateMap<CourseOrderInfo, CourseOrderInfoDto>().ReverseMap();
        }
    }
}
