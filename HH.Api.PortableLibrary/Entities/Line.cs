using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Line: BaseDictionaryEntity
	{

		[JsonProperty("hex_color")]
		public string HexColor { get; set; }

		[JsonProperty("stations")]
		public Station[] Stations { get; set; }

	}
}