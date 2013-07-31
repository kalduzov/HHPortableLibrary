using HH.Api.PortableLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HH.Api.PortableLibrary.Test
{
	[TestClass]
	public class VacanciesCommandTest
	{

		private ApiEntry _api;

		[TestInitialize]
		public void TestInit()
		{
			_api = new ApiEntry("", "TestUserAgent");
		}

		[TestMethod]
		public void GetVacancyTest()
		{
			var result = _api.VacanciesCommand.GetVacancy(8252535).Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetFavoritedTest()
		{
			var result = _api.VacanciesCommand.GetFavorited().Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void SearhTest()
		{
			var result = _api.VacanciesCommand.Search("test", new[]{new VacancySearchField {Id = "name"} }).Result;		
			Assert.IsNotNull(result);
		}
	}
}
