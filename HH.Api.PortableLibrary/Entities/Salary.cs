using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Salary
	{

		[JsonProperty("to")]
		public int? To { get; set; }

		[JsonProperty("from")]
		public int? From { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }
	}
}