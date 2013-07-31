using System.Collections.Generic;
using System.Threading.Tasks;
using HH.Api.PortableLibrary.Entities;

namespace HH.Api.PortableLibrary.Commands
{
	/// <summary>
	/// Справочники
	/// </summary>
	public class DictionaryCommand: BaseCommand
	{
		public DictionaryCommand(string accessToken) :
			base(accessToken)
		{
		}

		/// <summary>
		/// Возвращает древовидный список всех регионов с указанием названия региона, его ID и ссылкой на родительский регион
		/// </summary>
		public async Task<List<Area>> GetAreas()
		{
			var requestUrl = string.Format(UriDictionary.AREA_GET, "");
			return await SendGetRequest<List<Area>>(requestUrl);
		}

		/// <summary>
		/// Возвращает древовидный список регионов, начиная с указанного
		/// </summary>
		/// <param name="areaId">Идентификатор региона</param>
		public async Task<Area> GetArea(int areaId)
		{
			var requestUrl = string.Format(UriDictionary.AREA_GET, areaId);

			return await SendGetRequest<Area>(requestUrl);
		}

		/// <summary>
		/// Возвращает подробную информацию по указанному работодателю/компании
		/// </summary>
		/// <param name="employerId">Идентификатор работодателя</param>
		public async Task<Employer> GetEmployer(int employerId)
		{
			var requestUrl = string.Format(UriDictionary.EMPLOYER_GET, employerId);

			return await SendGetRequest<Employer>(requestUrl);
		}

		/// <summary>
		/// Возвращает справочник всех профессиональных областей и специализаций
		/// </summary>
		public async Task<List<Specialization>> GetSpecialization()
		{
			var requestUrl = string.Format(UriDictionary.SPECIALIZATION_GET);

			return await SendGetRequest<List<Specialization>>(requestUrl);
		}


		/// <summary>
		/// Возвращает список всех метро всех городов.
		/// </summary>
		public async Task<List<Metro>> GetMetroList()
		{
			var requestUrl = string.Format(UriDictionary.METRO_GET, "");

			return await SendGetRequest<List<Metro>>(requestUrl);
		}

		/// <summary>
		/// Возвращает список метро в указанном городе
		/// </summary>
		public async Task<Metro> GetMetroByCity(int cityId)
		{
			var requestUrl = string.Format(UriDictionary.METRO_GET, cityId);

			return await SendGetRequest<Metro>(requestUrl);
		}

		/// <summary>
		/// Возвращает объект со справочниками полей и сущностей, используемых в сервисе
		/// </summary>
		public async Task<Dictionaries> GetDictionaries()
		{
			var requestUrl = string.Format(UriDictionary.DICTIONARY_GET);

			return await SendGetRequest<Dictionaries>(requestUrl);
		}


	}
}
