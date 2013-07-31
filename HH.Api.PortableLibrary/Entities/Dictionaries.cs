using Newtonsoft.Json;


namespace HH.Api.PortableLibrary.Entities
{

	public class Dictionaries	
	{

		[JsonProperty("resume_contacts_site_type")]
		public ResumeContactsSiteType[] ResumeContactsSiteType { get; set; }

		[JsonProperty("schedule")]
		public Schedule[] Schedule { get; set; }

		[JsonProperty("business_trip_readiness")]
		public BusinessTripReadiness[] BusinessTripReadiness { get; set; }

		[JsonProperty("vacancy_search_fields")]
		public VacancySearchField[] VacancySearchFields { get; set; }

		[JsonProperty("currency")]
		public Currency[] Currency { get; set; }

		[JsonProperty("travel_time")]
		public TravelTime[] TravelTime { get; set; }

		[JsonProperty("education_level")]
		public EducationLevel[] EducationLevel { get; set; }

		[JsonProperty("relocation_type")]
		public RelocationType[] RelocationType { get; set; }

		[JsonProperty("resume_access_type")]
		public ResumeAccessType[] ResumeAccessType { get; set; }

		[JsonProperty("employment")]
		public Employment[] Employment { get; set; }

		[JsonProperty("vacancy_label")]
		public VacancyLabel[] VacancyLabel { get; set; }

		[JsonProperty("employer_type")]
		public EmployerType[] EmployerType { get; set; }

		[JsonProperty("gender")]
		public Gender[] Gender { get; set; }

		[JsonProperty("language_level")]
		public LanguageLevel[] LanguageLevel { get; set; }

		[JsonProperty("experience")]
		public Experience[] Experience { get; set; }

		[JsonProperty("preferred_contact_type")]
		public PreferredContactType[] PreferredContactType { get; set; }

		[JsonProperty("vacancy_search_order")]
		public VacancySearchOrder[] VacancySearchOrder { get; set; }

		[JsonProperty("vacancy_type")]
		public VacancyType[] VacancyType { get; set; }

		[JsonProperty("site_lang")]
		public SiteLang[] SiteLang { get; set; }
	}

}