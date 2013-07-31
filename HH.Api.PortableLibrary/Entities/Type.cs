using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Type
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}