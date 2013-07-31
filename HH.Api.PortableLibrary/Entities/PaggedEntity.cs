using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HH.Api.PortableLibrary.Entities
{
	public class PaggedEntity<T>
	{
		[JsonProperty("found")]
		public int? Found { get; set; }

		[JsonProperty("per_page")]
		public int? PerPage { get; set; }

		[JsonProperty("pages")]
		public int? Pages { get; set; }

		[JsonProperty("page")]
		public int? Page { get; set; }

		[JsonProperty("items")]
		public T[] Items { get; set; }

	}
}
