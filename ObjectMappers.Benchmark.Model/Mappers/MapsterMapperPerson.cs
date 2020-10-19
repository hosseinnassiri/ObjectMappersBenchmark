using FastExpressionCompiler;
using Mapster;
using ObjectMappers.Benchmark.Model.DataObjects;
using ObjectMappers.Benchmark.Model.Entities;
using System.Collections.Generic;

namespace ObjectMappers.Benchmark.Model.Mappers
{
	public static class MapsterMapperPerson
	{
		public static IList<Person> Map(ICollection<PersonDto> items) =>
			items.Adapt<ICollection<PersonDto>, IList<Person>>();
	}
}
