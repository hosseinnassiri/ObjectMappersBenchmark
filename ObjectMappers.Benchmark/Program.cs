using BenchmarkDotNet.Running;
using ObjectMappers.Benchmark.Model.DataObjects;
using ObjectMappers.Benchmark.Model.Mappers;
using System.Collections.Generic;

namespace ObjectMappers.Benchmark
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//var result = AutoMapperPerson.Map(
			//	new List<PersonDto> { new PersonDto { Name = "Ali", Addresses = new List<AddressDto> { new AddressDto { Line1 = "somewhere" } } } });
			//var result = MapsterMapperPerson.Map(
			//	new List<PersonDto> { new PersonDto { Name = "Ali", Addresses = new List<AddressDto> { new AddressDto { Line1 = "somewhere" } } } });
			var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
		}
	}
}
