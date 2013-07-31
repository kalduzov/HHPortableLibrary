using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Employer: BaseDictionaryEntity
	{

		[JsonProperty("logo_urls")]
		public LogoUrls LogoUrls { get; set; }

		[JsonProperty("vacancies_url")]
		public string VacanciesUrl { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("alternate_url")]
		public string AlternateUrl { get; set; }

		[JsonProperty("site_url")]
		public string SiteUrl { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("trusted")]
		public bool? Trusted { get; set; }

	}
}