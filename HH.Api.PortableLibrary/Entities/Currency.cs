using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Currency
	{

		[JsonProperty("default")]
		public bool? Default { get; set; }

		[JsonProperty("rate")]
		public double? Rate { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("abbr")]
		public string Abbr { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}