﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HH.Api.PortableLibrary.Entities;

namespace HH.Api.PortableLibrary.Entities
{
}

namespace HH.Api.PortableLibrary.Entities
{

    public class Vacancy
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }

        [JsonProperty("accept_handicapped")]
        public bool AcceptHandicapped { get; set; }

        [JsonProperty("experience")]
        public Experience Experience { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateUrl { get; set; }

        [JsonProperty("employment")]
        public Employment Employment { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("salary")]
        public Salary Salary { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public Area Area { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("relations")]
        public object[] Relations { get; set; }

        [JsonProperty("employer")]
        public Employer Employer { get; set; }

        [JsonProperty("response_letter_required")]
        public bool ResponseLetterRequired { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("specializations")]
        public Specialization[] Specializations { get; set; }
    }

}
