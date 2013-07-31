using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class PreferredContactType
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}