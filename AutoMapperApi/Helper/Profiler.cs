using AutoMapper;
using AutoMapperApi.Enum;
using AutoMapperApi.Model;
using AutoMapperApi.ViewModel;

namespace AutoMapperApi.Helper
{
    public class Profiler : Profile
    {
        public Profiler()
        {
            CreateMap<Student, StudentVm>().ReverseMap();
            CreateMap<Guardian, GuardianVm>().ReverseMap();
            CreateMap<Address, AddressVm>().ReverseMap();

            CreateMap<Gender, VmSelectList>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => (int)src))
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ToString())).ReverseMap();


            CreateMap<Student, CreateOrUpdateStudentVm>().ReverseMap();
            CreateMap<Guardian, CreateOrUpdateGuardianVm>().ReverseMap();
        }
    }
}
