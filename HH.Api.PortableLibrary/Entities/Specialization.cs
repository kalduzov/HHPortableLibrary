using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class Specialization: BaseDictionaryEntity
	{
		[JsonProperty("profarea_id")]
		public string ProfareaId { get; set; }

		[JsonProperty("profarea_name")]
		public string ProfareaName { get; set; }

		[JsonProperty("specializations")]
		public Specialization[] Specializations { get; set; }

	}
}