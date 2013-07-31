using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Area: BaseDictionaryEntity
	{

		[JsonProperty("parent_id")]
		public int? ParentId { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("areas")]
		public Area[] Areas { get; set; }

	}
}