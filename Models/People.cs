using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SSC.Models
{
    [Table("PEOPLE")]
    [Index(nameof(PersonId), Name = "uqPeoplePersonId", IsUnique = true)]
    public partial class People
    {
        [Required]
        [Column("PEOPLE_CODE")]
        [StringLength(1)]
        public string PeopleCode { get; set; }
        [Required]
        [Column("PEOPLE_ID")]
        [StringLength(9)]
        public string PeopleId { get; set; }
        [Key]
        [Column("PEOPLE_CODE_ID")]
        [StringLength(10)]
        public string PeopleCodeId { get; set; }
        [Column("PREVIOUS_ID")]
        [StringLength(9)]
        public string PreviousId { get; set; }
        [Column("GOVERNMENT_ID")]
        [StringLength(20)]
        public string GovernmentId { get; set; }
        [Column("PREV_GOV_ID")]
        [StringLength(20)]
        public string PrevGovId { get; set; }
        [Column("PREFIX")]
        [StringLength(15)]
        public string Prefix { get; set; }
        [Required]
        [Column("FIRST_NAME")]
        [StringLength(60)]
        public string FirstName { get; set; }
        [Required]
        [Column("MIDDLE_NAME")]
        [StringLength(60)]
        public string MiddleName { get; set; }
        [Required]
        [Column("LAST_NAME")]
        [StringLength(60)]
        public string LastName { get; set; }
        [Column("SUFFIX")]
        [StringLength(15)]
        public string Suffix { get; set; }
        [Column("NICKNAME")]
        [StringLength(60)]
        public string Nickname { get; set; }
        [Required]
        [Column("PREFERRED_ADD")]
        [StringLength(4)]
        public string PreferredAdd { get; set; }
        [Column("BIRTH_DATE", TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [Column("BIRTH_CITY")]
        [StringLength(30)]
        public string BirthCity { get; set; }
        [Column("BIRTH_STATE")]
        [StringLength(4)]
        public string BirthState { get; set; }
        [Column("BIRTH_ZIP_CODE")]
        [StringLength(15)]
        public string BirthZipCode { get; set; }
        [Column("BIRTH_COUNTRY")]
        [StringLength(6)]
        public string BirthCountry { get; set; }
        [Column("BIRTH_COUNTY")]
        [StringLength(6)]
        public string BirthCounty { get; set; }
        [Column("DECEASED_DATE", TypeName = "datetime")]
        public DateTime? DeceasedDate { get; set; }
        [Required]
        [Column("DECEASED_FLAG")]
        [StringLength(1)]
        public string DeceasedFlag { get; set; }
        [Column("RELEASE_INFO")]
        [StringLength(6)]
        public string ReleaseInfo { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column("CREATE_TIME", TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Required]
        [Column("CREATE_OPID")]
        [StringLength(8)]
        public string CreateOpid { get; set; }
        [Required]
        [Column("CREATE_TERMINAL")]
        [StringLength(4)]
        public string CreateTerminal { get; set; }
        [Column("REVISION_DATE", TypeName = "datetime")]
        public DateTime RevisionDate { get; set; }
        [Column("REVISION_TIME", TypeName = "datetime")]
        public DateTime RevisionTime { get; set; }
        [Required]
        [Column("REVISION_OPID")]
        [StringLength(8)]
        public string RevisionOpid { get; set; }
        [Required]
        [Column("REVISION_TERMINAL")]
        [StringLength(4)]
        public string RevisionTerminal { get; set; }
        [Required]
        [Column("ABT_JOIN")]
        [StringLength(1)]
        public string AbtJoin { get; set; }
        [Column("TAX_ID")]
        [StringLength(9)]
        public string TaxId { get; set; }
        public int PersonId { get; set; }
        public int? PrimaryPhoneId { get; set; }
        [Column("Last_Name_Prefix")]
        [StringLength(60)]
        public string LastNamePrefix { get; set; }
        [StringLength(300)]
        public string LegalName { get; set; }
        [StringLength(60)]
        public string DisplayName { get; set; }
        [StringLength(10)]
        public string GenderIdentity { get; set; }
        [StringLength(10)]
        public string Pronoun { get; set; }
        public int? PrimaryEmailId { get; set; }
    }
}