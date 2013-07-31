using System.Collections.Generic;
using System.Threading.Tasks;
using HH.Api.PortableLibrary.Entities;

namespace HH.Api.PortableLibrary.Commands
{
	/// <summary>
	/// Команды связанные с пользователем
	/// </summary>
	public class UserCommand: BaseCommand
	{
		public UserCommand(string accessToken) :
			base(accessToken)
		{
		}

		/// <summary>
		/// Возвращает список резюме авторизованного пользователя
		/// </summary>
		public async Task<PaggedEntity<Resume>> GetResumes(int page = 0, int perPage = 20)
		{
			var requestUrl = string.Format(UriDictionary.RESUME_GET_MINE, page, perPage);
			return await SendGetRequest<PaggedEntity<Resume>>(requestUrl);
		}

		/// <summary>
		/// Возвращает резюме авторизованного пользователя
		/// </summary>
		public async Task<Resume> GetResumeById(string resumeId)
		{
			var requestUrl = string.Format(UriDictionary.RESUME_GET, resumeId);
			return await SendGetRequest<Resume>(requestUrl);
		}


		/// <summary>
		/// Возвращает информацию о текущем авторизованном пользователе
		/// </summary>
		public async Task<User> GetCurrentUser()
		{
			var requestUrl = string.Format(UriDictionary.USER_GET, "");
			return await SendGetRequest<User>(requestUrl);
		}
	}
}
