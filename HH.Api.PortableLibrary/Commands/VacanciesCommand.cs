using System;
using System.Text;
using System.Threading.Tasks;
using HH.Api.PortableLibrary.Entities;

namespace HH.Api.PortableLibrary.Commands
{
	/// <summary>
	/// Вакансии
	/// </summary>
	public class VacanciesCommand: BaseCommand
	{
		public VacanciesCommand(string accessToken) :
			base(accessToken)
		{
		}

		/// <summary>
		/// Возвращает подробную информацию по указанной вакансии
		/// </summary>
		/// <param name="vacancyId">Идентификатор вакансии</param>
		public async Task<Vacancy> GetVacancy(int vacancyId)
		{
			var requestUrl = string.Format(UriDictionary.VACANCY_GET, vacancyId);

			return await SendGetRequest<Vacancy>(requestUrl);
		}

		/// <summary>
		/// Возвращает подмножество вакансий, добавленных пользователем в отобранные
		/// </summary>
		/// <param name="page">Страница</param>
		/// <param name="perPage">Количество вакансий на странице</param>
		public async Task<PaggedEntity<Vacancy>> GetFavorited(int page = 0, int perPage = 20)
		{
			var requestUrl = string.Format(UriDictionary.VACANCY_GET_FAVORITED_PAGE, page, perPage);

			return await SendGetRequest<PaggedEntity<Vacancy>>(requestUrl);
		}

		/// <summary>
		/// Добавляет указанную вакансию в список
		/// </summary>
		/// <param name="vacancyId"></param>
		public async void AddFavorited(int vacancyId)
		{
			var requestUrl = string.Format(UriDictionary.VACANCY_PUT_DELETE_FAVORITED, vacancyId);
			await Task.Factory.StartNew(() => SendPutRequest(requestUrl, string.Empty));
		}

		/// <summary>
		/// Добавляет указанную вакансию в список
		/// </summary>
		/// <param name="vacancyId">Идентификатор вакансии</param>
		public async void DeleteFavorited(int vacancyId)
		{
			var requestUrl = string.Format(UriDictionary.VACANCY_PUT_DELETE_FAVORITED, vacancyId);
			await Task.Factory.StartNew(() => SendDeleteRequest(requestUrl));

		}

		/// <summary>
		/// Поиск по вакансиям
		/// </summary>
		/// <param name="text">Переданное значение ищется в полях вакансии</param>
		/// <param name="searchFields">Область поиска</param>
		/// <param name="experience">Опыт работы</param>
		/// <param name="employments">Тип занятости</param>
		/// <param name="schedules">График работы</param>
		/// <param name="areas">Регион</param>
		/// <param name="metros">Ветка или станция метро</param>
		/// <param name="specializations">Профобласть или специализация</param>
		/// <param name="employers">Компании</param>
		/// <param name="currency">Код валюты</param>
		/// <param name="salary">Размер заработной платы</param>
		/// <param name="labels">Фильтр по меткам вакансий</param>
		/// <param name="onlyWithSalary">Показывать вакансии только с указанием зарплаты</param>
		/// <param name="period">Количество дней, в пределах которых нужно найти вакансии</param>
		/// <param name="vacancySearchOrder">Сортировка списка вакансий</param>
		/// <param name="coordinate">Значение гео-координат</param>
		/// <param name="page">Страница</param>
		/// <param name="perPage">Количество вакансий на странице</param>
		/// <returns>Список вакансий, удовлетворяющий заданным условиям</returns>
		public async Task<PaggedEntity<Vacancy>> Search(string text = null, VacancySearchField[] searchFields = null, Experience experience = null,
			Employment[] employments = null, Schedule[] schedules = null, Area[] areas = null, Metro[] metros = null, Specialization[] specializations = null,
			Employer[] employers = null, Currency currency = null, double salary = 0, VacancyLabel[] labels = null, bool onlyWithSalary = false, int period = 30,
			VacancySearchOrder vacancySearchOrder = null, Coordinate coordinate = null, int page = 0, int perPage = 20)
		{

			var sb = new StringBuilder(1000);

			sb.Append(string.Format(UriDictionary.BASE_URI + "/vacancies/?page={0}&per_page={1}&only_with_salary={2}&period={3}", page, perPage, onlyWithSalary.ToString().ToLower(), period));

			if(!string.IsNullOrEmpty(text))
				sb.AppendFormat("&text={0}", text);

			if(searchFields != null)
				sb.Append(GenerateSequence("search_field", searchFields));

			if(experience != null)
				sb.AppendFormat("&experience={0}", experience.Id);

			if(employments != null)
				sb.Append(GenerateSequence("employment", employments));

			if(schedules != null)
				sb.Append(GenerateSequence("schedule", schedules));

			if(areas != null)
				sb.Append(GenerateSequence("area", areas));

			if(metros != null)
				sb.Append(GenerateSequence("metro", metros));

			if(specializations != null)
				sb.Append(GenerateSequence("specialization", specializations));

			if(employers != null)
				sb.Append(GenerateSequence("employer_id", employers));

			if(currency != null)
				sb.AppendFormat("&currency={0}", currency.Code);

			if(salary > 0)
				sb.AppendFormat("&salary={0}", salary);

			if(labels != null)
				sb.Append(GenerateSequence("labels", labels));

			if(vacancySearchOrder != null)
				sb.AppendFormat("&order_by ={0}", vacancySearchOrder.Id);

			if(coordinate != null)
				sb.AppendFormat("&top_lat={0}&bottom_lat={1}&left_lng={2}&right_lng={3}", coordinate.TopLat, coordinate.BottomLat, coordinate.LeftLng, coordinate.RightLng);


			var requestUrl = sb.ToString();


			return await SendGetRequest<PaggedEntity<Vacancy>>(requestUrl);
		}

		private static string GenerateSequence<T>(string paramName, T[] paramValues) where T: BaseDictionaryEntity
		{
			if(paramValues == null)
				throw new ArgumentNullException("paramValues");

			var r = new StringBuilder(paramValues.Length * (paramName.Length + 12));

			foreach(T t in paramValues)
				r.AppendFormat("&{0}={1}", paramName, t.Id);

			return r.ToString();
		}
	}
}
