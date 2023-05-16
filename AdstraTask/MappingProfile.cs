using AdstraTask.Models;
using AutoMapper;

namespace AdstraTask
{

    public static class Mapping
    {

        private static readonly Lazy<IMapper> lazy= new Lazy<IMapper> (()=>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper(); 
            return mapper;
        });   

       public static IMapper Mapper => lazy.Value;  

    }

    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();  
        }


    }
}
