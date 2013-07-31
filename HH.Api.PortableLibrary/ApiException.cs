using System;
using System.Net;
using HH.Api.PortableLibrary.Entities;

namespace HH.Api.PortableLibrary
{

	public class ApiException: Exception
	{

		public ApiException()
		{
		}

		public ApiException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public HttpStatusCode StatusCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Uri { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Error Error { get; set; }
	}
}
