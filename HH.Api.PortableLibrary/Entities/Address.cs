using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Address
	{

		[JsonProperty("building")]
		public object Building { get; set; }

		[JsonProperty("city")]
		public object City { get; set; }

		[JsonProperty("street")]
		public object Street { get; set; }

		[JsonProperty("description")]
		public object Description { get; set; }

		[JsonProperty("metro")]
		public MetroSummary Metro { get; set; }

		[JsonProperty("raw")]
		public object Raw { get; set; }

		[JsonProperty("lat")]
		public object Lat { get; set; }

		[JsonProperty("lng")]
		public object Lng { get; set; }
	}

}