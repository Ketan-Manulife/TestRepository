﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.DTOs
{
    /// <summary>
    /// Class Dependent Request Model.
    /// </summary>
    public partial class DependentRequestModel
    {
        /// <summary>
        /// Gets or sets the person link type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PersonLinkTypeCd")]
        public int? PersonLinkTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the status cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("StatusCd")]
        public int? StatusCd { get; set; }

        /// <summary>
        /// Gets or sets the effective dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDt")]
        public System.DateTimeOffset? EffectiveDt { get; set; }

        /// <summary>
        /// Gets or sets the term dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TermDt")]
        public System.DateTimeOffset? TermDt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [late entrant FLG].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LateEntrantFlg")]
        public bool? LateEntrantFlg { get; set; }

        /// <summary>
        /// Gets or sets the late entrant expry dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LateEntrantExpryDt")]
        public System.DateTimeOffset? LateEntrantExpryDt { get; set; }

        /// <summary>
        /// Gets or sets the global update identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GlobalUpdateId")]
        public int? GlobalUpdateId { get; set; }

        /// <summary>
        /// Gets or sets the term reason cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TermReasonCd")]
        public int? TermReasonCd { get; set; }

        /// <summary>
        /// Gets or sets the trustee nm.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TrusteeNm")]
        public string TrusteeNm { get; set; }

        /// <summary>
        /// Gets or sets the relationship dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RelationshipDt")]
        public System.DateTimeOffset? RelationshipDt { get; set; }

        /// <summary>
        /// Gets or sets the person link sub cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PersonLinkSubCd")]
        public int? PersonLinkSubCd { get; set; }

        /// <summary>
        /// Gets or sets the person add dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PersonAddDt")]
        public System.DateTimeOffset? PersonAddDt { get; set; }

        /// <summary>
        /// Gets or sets the social number.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SocialNum")]
        public string SocialNum { get; set; }

        /// <summary>
        /// Gets or sets the first nm.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FirstNm")]
        public string FirstNm { get; set; }

        /// <summary>
        /// Gets or sets the middle initial nm.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MiddleInitialNm")]
        public string MiddleInitialNm { get; set; }

        /// <summary>
        /// Gets or sets the last nm.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LastNm")]
        public string LastNm { get; set; }

        /// <summary>
        /// Gets or sets the certificate number.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CertificateNum")]
        public string CertificateNum { get; set; }

        /// <summary>
        /// Gets or sets the birth dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BirthDt")]
        public System.DateTimeOffset? BirthDt { get; set; }

        /// <summary>
        /// Gets or sets the gender cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GenderCd")]
        public int? GenderCd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [smoker FLG].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SmokerFlg")]
        public bool? SmokerFlg { get; set; }

        /// <summary>
        /// Gets or sets the residence cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ResidenceCd")]
        public int? ResidenceCd { get; set; }

        /// <summary>
        /// Gets or sets the language cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LanguageCd")]
        public int? LanguageCd { get; set; }

        /// <summary>
        /// Gets or sets the dep type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DepTypeCd")]
        public int? DepTypeCd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [tax exempt FLG].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TaxExemptFlg")]
        public bool? TaxExemptFlg { get; set; }

        /// <summary>
        /// Gets or sets the entry number.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EntryNum")]
        public string EntryNum { get; set; }

        /// <summary>
        /// Gets or sets the acquired dt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("AcquiredDt")]
        public System.DateTimeOffset? AcquiredDt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [in school FLG].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("InSchoolFlg")]
        public bool? InSchoolFlg { get; set; }

        /// <summary>
        /// Gets or sets the school cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SchoolCd")]
        public int? SchoolCd { get; set; }

        /// <summary>
        /// Gets or sets the notice cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("NoticeCd")]
        public int? NoticeCd { get; set; }

        /// <summary>
        /// Gets or sets the memo text.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemoTxt")]
        public string MemoTxt { get; set; }

        /// <summary>
        /// Gets or sets the salutation nm.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SalutationNm")]
        public string SalutationNm { get; set; }

        /// <summary>
        /// Gets or sets the last mod no.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LastModNo")]
        public int? LastModNo { get; set; }

        /// <summary>
        /// Gets or sets the multiple birth cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MultipleBirthCd")]
        public int? MultipleBirthCd { get; set; }

        /// <summary>
        /// Gets or sets the manual adj cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ManualAdjCd")]
        public int? ManualAdjCd { get; set; }

        /// <summary>
        /// Gets or sets the health number.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("HealthNum")]
        public string HealthNum { get; set; }

        /// <summary>
        /// Gets or sets the health number type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("HealthNumTypeCd")]
        public int? HealthNumTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the participate prov health cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ParticipateProvHealthCd")]
        public int? ParticipateProvHealthCd { get; set; }
    }
}
