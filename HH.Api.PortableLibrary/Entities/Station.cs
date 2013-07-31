using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Station: BaseDictionaryEntity
	{

		[JsonProperty("lat")]
		public double? Lat { get; set; }

		[JsonProperty("lng")]
		public double? Lng { get; set; }

		[JsonProperty("order")]
		public int? Order { get; set; }

	}
}