using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{

	public class Metro: BaseDictionaryEntity
	{

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("lines")]
		public Line[] Lines { get; set; }

	}

}
