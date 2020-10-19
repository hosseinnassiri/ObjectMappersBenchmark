using BenchmarkDotNet.Attributes;
using Bogus;
using FastExpressionCompiler;
using Mapster;
using ObjectMappers.Benchmark.Model.DataObjects;
using ObjectMappers.Benchmark.Model.Entities;
using ObjectMappers.Benchmark.Model.Mappers;
using System.Collections.Generic;

namespace ObjectMappers.Benchmark
{
	[MarkdownExporter, HtmlExporter]
	[MemoryDiagnoser]
	[SimpleJob(launchCount: 3, warmupCount: 3, targetCount: 20)]
	public class BenchmarkTests
	{
		private List<PersonDto> _items;

		[GlobalSetup]
		public void GlobalSetup()
		{
			var testAddressTemplate = new Faker<AddressDto>()
				.RuleFor(u => u.Line1, f => f.Address.StreetName())
				.RuleFor(u => u.City, f => f.Address.City())
				.RuleFor(u => u.PostalCode, f => f.Address.ZipCode());

			var testRelatedPersonTemplate = new Faker<RelatedPersonDto>()
				.RuleFor(u => u.Name, f => f.Name.FullName())
				.RuleFor(u => u.Nationality, f => f.Address.Country());

			var testPersonTemplate = new Faker<PersonDto>()
				.RuleFor(u => u.Name, f => f.Name.FullName())
				.RuleFor(u => u.BirthDate, f => f.Date.Past())
				.RuleFor(u => u.Nationality, f => f.Address.Country())
				.RuleFor(u => u.Addresses, _ => testAddressTemplate.Generate(3))
				.RuleFor(u => u.RelatedPersons, _ => testRelatedPersonTemplate.Generate(5));

			_items = testPersonTemplate.Generate(10000);

			TypeAdapterConfig.GlobalSettings.Compiler = exp => exp.CompileFast();
			TypeAdapterConfig.GlobalSettings.Compile(typeof(PersonDto), typeof(Model.Entities.Person));    //recompile
		}

		[Benchmark(Baseline = true)]
		public IList<Model.Entities.Person> ManualMapping() =>
			ManualMapper.Map(_items);

		[Benchmark]
		public IList<Model.Entities.Person> AutoMapperMapping() =>
			AutoMapperPerson.Map(_items);

		[Benchmark]
		public IList<Model.Entities.Person> MapsterMapping() =>
			MapsterMapperPerson.Map(_items);
	}
}
