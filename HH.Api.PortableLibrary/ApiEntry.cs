using HH.Api.PortableLibrary.Commands;

namespace HH.Api.PortableLibrary
{

	/// <summary>
	/// Общая точка для всех методов API
	/// </summary>
	public class ApiEntry
	{
		private readonly string _accessToken;
		private readonly string _userAgent;
		private VacanciesCommand _vacanciesCommand;
		private DictionaryCommand _dictionaryCommand;
		private UserCommand _userCommand;

		/// <summary>
		/// Создает точку входа в API
		/// </summary>
		/// <param name="accessToken">Токен доступа</param>
		/// <param name="userAgent">Пользовательский UserAgent для заголовков</param>
		public ApiEntry(string accessToken, string userAgent)
		{
			_accessToken = accessToken;
			_userAgent = userAgent;
		}

		/// <summary>
		/// Методы работы с вакансиями
		/// </summary>
		public VacanciesCommand VacanciesCommand
		{
			get
			{
				return _vacanciesCommand ?? (_vacanciesCommand = new VacanciesCommand(_accessToken) { UserAgent = _userAgent });
			}
			set { _vacanciesCommand = value; }
		}

		/// <summary>
		/// Методы работы со словарями
		/// </summary>
		public DictionaryCommand DictionaryCommand
		{
			get { return _dictionaryCommand ?? (_dictionaryCommand = new DictionaryCommand(_accessToken) { UserAgent = _userAgent }); }
			set { _dictionaryCommand = value; }
		}

		/// <summary>
		/// Методы работы с пользовательской информацией
		/// </summary>
		public UserCommand UserCommand
		{
			get { return _userCommand ?? (_userCommand = new UserCommand(_accessToken) { UserAgent = _userAgent }); }
			set { _userCommand = value; }
		}
	}
}
