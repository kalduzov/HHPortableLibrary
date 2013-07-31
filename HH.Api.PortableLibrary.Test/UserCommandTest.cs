using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HH.Api.PortableLibrary.Test
{
	[TestClass]
	public class UserCommandTest
	{

		private ApiEntry _api;

		[TestInitialize]
		public void TestInit()
		{
			_api = new ApiEntry("", "TestUserAgent");
		}

		[TestMethod]
		public void GetCurrentUserTest()
		{
			var result = _api.UserCommand.GetCurrentUser().Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetResumeByIdTest()
		{
			var result = _api.UserCommand.GetResumeById("").Result;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetResumesTest()
		{
			var result = _api.UserCommand.GetResumes().Result;
			Assert.IsNotNull(result);
		}
	}
}
