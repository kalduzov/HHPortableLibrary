using System;

namespace HH.Api.PortableLibrary.Commands
{
	internal class UriDictionary
	{


		internal const string BASE_URI = "https://api.hh.ru";

		public const string VACANCY_GET = BASE_URI + "/vacancies/{0}";

		public const string VACANCY_GET_FAVORITED_PAGE = BASE_URI + "/vacancies/favorited/?page={0}&per_page={1}";

		public const string VACANCY_PUT_DELETE_FAVORITED = BASE_URI + "/vacancies/favorited/{0}";

		public const string EMPLOYER_GET = BASE_URI + "/employers/{0}";

		public const string AREA_GET = BASE_URI + "/areas/{0}";

		public const string SPECIALIZATION_GET = BASE_URI + "/specializations/";

		public const string METRO_GET = BASE_URI + "/metro/{0}";

		public const string DICTIONARY_GET = BASE_URI + "/dictionaries/";

		public const string RESUME_GET = BASE_URI + "/resumes/{0}";

		public const string RESUME_GET_MINE = BASE_URI + "/resumes/mine/?page={0}&per_page={1}";

		public const string USER_GET = BASE_URI + "/me/{0}";
	}
}