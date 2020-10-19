using AutoMapper;
using ObjectMappers.Benchmark.Model.DataObjects;
using ObjectMappers.Benchmark.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ObjectMappers.Benchmark.Model.Mappers
{
	public static class AutoMapperPerson
	{
		private static readonly IMapper mapper = new MapperConfiguration(cfg =>
		{
			cfg.CreateMap<PersonDto, Person>();
			cfg.CreateMap<AddressDto, Address>();
			cfg.CreateMap<RelatedPersonDto, RelatedPerson>();
		}).CreateMapper();

		public static IList<Person> Map(ICollection<PersonDto> items) =>
			mapper.Map<IEnumerable<PersonDto>, IEnumerable<Person>>(items).ToList();
	}
}
