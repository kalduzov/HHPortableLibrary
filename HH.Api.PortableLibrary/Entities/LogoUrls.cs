using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class LogoUrls
	{

		[JsonProperty("90")]
		public string Size90 { get; set; }

		[JsonProperty("240")]
		public string Size240 { get; set; }

		[JsonProperty("original")]
		public string Original { get; set; }
	}
}