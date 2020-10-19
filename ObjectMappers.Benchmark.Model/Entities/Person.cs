using System;
using System.Collections.Generic;

namespace ObjectMappers.Benchmark.Model.Entities
{
	public sealed class Person
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public string Nationality { get; set; }
		public ICollection<Address> Addresses { get; set; }
		public ICollection<RelatedPerson> RelatedPersons { get; set; }
	}

	public class RelatedPerson
	{
		public string Name { get; set; }
		public string Nationality { get; set; }
	}

	public sealed class Address
	{
		public string Line1 { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
	}
}
