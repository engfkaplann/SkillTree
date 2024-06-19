using AutoMapper;
using SkillTree.Mapping.Models.Dtos;
using SkillTree.Mapping.Models.Entities;
using SkillTree.Mapping.Models.Mapping;
using System;

namespace SkillTree.Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source(1, "John");
            Destination destination1 = CustomMapping(source);
            Destination destination2 = AutoMapperMapping(source);

            Console.ReadLine();
        }

        private static Destination CustomMapping(Source source)
        {
            return CustomMapper<Source, Destination>.Map(source);
        }

        private static Destination AutoMapperMapping(Source source)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Source, Destination>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name.ToUpper()));
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<Source, Destination>(source);
        }
    }
}
