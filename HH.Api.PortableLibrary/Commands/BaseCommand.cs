using System.Net.Http;
using System.Threading.Tasks;
using HH.Api.PortableLibrary.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HH.Api.PortableLibrary.Commands
{
	/// <summary>
	/// Базовый класс для вызовов
	/// </summary>
	public abstract class BaseCommand
	{
		private readonly string _accessToken;

		public string UserAgent { get; set; }

		protected BaseCommand(string accessToken)
		{
			_accessToken = accessToken;
		}

		private HttpClient HttpClientInit()
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
			httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
			return httpClient;
		}

		protected async Task<T> SendGetRequest<T>(string uri)
		{
			var httpClient = HttpClientInit();

			var response = await httpClient.GetAsync(uri);
			StatusCodeAnalize(response);
			var content = await response.Content.ReadAsStringAsync();
			return ParseResult<T>(content);

		}

		protected async void SendPutRequest(string uri, string putData)
		{
			var httpClient = HttpClientInit();

			var response = await httpClient.PutAsync(uri, new StringContent(putData));
			StatusCodeAnalize(response);
		}

		protected async Task<T> SendPostRequest<T>(string uri, string postData)
		{

			var httpClient = HttpClientInit();
			var response = await httpClient.PostAsync(uri, new StringContent(postData));
			StatusCodeAnalize(response);
			var content = await response.Content.ReadAsStringAsync();
			return ParseResult<T>(content);
		}

		protected async void SendDeleteRequest(string uri)
		{
			var httpClient = HttpClientInit();
			var response = await httpClient.DeleteAsync(uri);
			StatusCodeAnalize(response);
		}

		private void StatusCodeAnalize(HttpResponseMessage response)
		{
			if(response.IsSuccessStatusCode)
				return;

			var content = response.Content.ReadAsStringAsync().Result;

			var json = JObject.Parse(content);
			var error = json.ToObject<Error>();
			throw new ApiException(error.Description) { Error = error, StatusCode = response.StatusCode, Uri = response.RequestMessage.RequestUri.AbsoluteUri };
		}

		private static T ParseResult<T>(string result)
		{
			var json = JObject.Parse("{\"result\": " + result + "}");
			JToken jt;
			if(json.TryGetValue("result", out jt))
				return jt.ToObject<T>();
			throw new ApiException("Json parse error");
		}

	}
}
