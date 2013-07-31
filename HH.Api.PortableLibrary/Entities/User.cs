using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	/// <summary>
	/// Информация о пользователе
	/// </summary>
	public class User
	{
		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("is_admin")]
		public bool IsAdmin { get; set; }

		[JsonProperty("is_applicant")]
		public bool IsApplicant { get; set; }

		[JsonProperty("is_employer")]
		public bool IsEmployer { get; set; }

		[JsonProperty("mid_name")]
		public string MidName { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("employer")]
		public Employer Employer { get; set; }
	}
}