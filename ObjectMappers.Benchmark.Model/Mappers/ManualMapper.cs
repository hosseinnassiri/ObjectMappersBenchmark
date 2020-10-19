using ObjectMappers.Benchmark.Model.DataObjects;
using ObjectMappers.Benchmark.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ObjectMappers.Benchmark.Model.Mappers
{
	public static class ManualMapper
	{
		public static IList<Person> Map(ICollection<PersonDto> items) =>
			items.Select(x => Map(x)).ToList();

		public static Person Map(PersonDto item) => new Person
		{
			Name = item.Name,
			BirthDate = item.BirthDate,
			Nationality = item.Nationality,
			Addresses = item.Addresses.Select(x => Map(x)).ToList(),
			RelatedPersons = item.RelatedPersons.Select(x => Map(x)).ToList()
		};

		private static Address Map(AddressDto item) => new Address
		{
			Line1 = item.Line1,
			City = item.City,
			PostalCode = item.PostalCode
		};

		private static RelatedPerson Map(RelatedPersonDto item) => new RelatedPerson
		{
			Name = item.Name,
			Nationality = item.Nationality
		};
	}
}
