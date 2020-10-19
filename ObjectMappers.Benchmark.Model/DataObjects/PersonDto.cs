using System;
using System.Collections.Generic;

namespace ObjectMappers.Benchmark.Model.DataObjects
{
	public sealed class PersonDto
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public string Nationality { get; set; }
		public ICollection<AddressDto> Addresses { get; set; }
		public ICollection<RelatedPersonDto> RelatedPersons { get; set; }
	}

	public class RelatedPersonDto
	{
		public string Name { get; set; }
		public string Nationality { get; set; }
	}

	public sealed class AddressDto
	{
		public string Line1 { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
	}
}
