using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HH.Api.PortableLibrary.Test
{
	[TestClass]
	public class DictionaryCommandTest
	{

		private ApiEntry _api;

		[TestInitialize]
		public void TestInit()
		{
			_api = new ApiEntry("", "TestUserAgent");
		}

		[TestMethod]
		public void GetAreaTest()
		{
			var result = _api.DictionaryCommand.GetArea(1146).Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetAreasTest()
		{
			var result = _api.DictionaryCommand.GetAreas().Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetDictionariesTest()
		{
			var result = _api.DictionaryCommand.GetDictionaries().Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetEmployerTest()
		{
			var result = _api.DictionaryCommand.GetEmployer(1455).Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetMetroByCityTest()
		{
			var result = _api.DictionaryCommand.GetMetroByCity(1).Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetMetroListTest()
		{
			var result = _api.DictionaryCommand.GetMetroList().Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetSpecializationTest()
		{
			var result = _api.DictionaryCommand.GetSpecialization().Result;
			Assert.IsNotNull(result);
		}

	}
}
