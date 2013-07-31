using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	/// <summary>
	/// Описание ошибки
	/// </summary>
	public class Error
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("bad_argument")]
		public string BadArgument { get; set; }
	}
}