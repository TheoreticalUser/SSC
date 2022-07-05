using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SSC.Models
{
    [Table("TRANSCRIPTDETAIL")]
    [Index(nameof(PeopleCodeId), nameof(AcademicYear), nameof(AcademicTerm), nameof(TranscriptSeq), Name = "ixTranscriptDetail_PersonYTSequence")]
    [Index(nameof(PeopleCodeId), nameof(EventId), nameof(EventSubType), Name = "ixTranscriptDetail_Person_Event")]
    [Index(nameof(AcademicYear), nameof(AcademicTerm), nameof(AcademicSession), nameof(EventId), nameof(EventSubType), nameof(Section), nameof(AddDropWait), Name = "ixTranscriptDetail_SectionADW")]
    [Index(nameof(PeopleCodeId), nameof(AcademicYear), nameof(AcademicTerm), nameof(AcademicSession), nameof(EventId), nameof(EventSubType), nameof(Section), Name = "ixTranscriptDetail_UQ_PersonSection", IsUnique = true)]
    public partial class Transcriptdetail
    {
        [Required]
        [Column("PEOPLE_CODE")]
        [StringLength(1)]
        public string PeopleCode { get; set; }
        [Required]
        [Column("PEOPLE_ID")]
        [StringLength(9)]
        public string PeopleId { get; set; }
        [Required]
        [Column("PEOPLE_CODE_ID")]
        [StringLength(10)]
        public string PeopleCodeId { get; set; }
        [Required]
        [Column("ACADEMIC_YEAR")]
        [StringLength(4)]
        public string AcademicYear { get; set; }
        [Required]
        [Column("ACADEMIC_TERM")]
        [StringLength(10)]
        public string AcademicTerm { get; set; }
        [Required]
        [Column("ACADEMIC_SESSION")]
        [StringLength(10)]
        public string AcademicSession { get; set; }
        [Required]
        [Column("EVENT_ID")]
        [StringLength(15)]
        public string EventId { get; set; }
        [Required]
        [Column("EVENT_SUB_TYPE")]
        [StringLength(4)]
        public string EventSubType { get; set; }
        [Required]
        [Column("SECTION")]
        [StringLength(4)]
        public string Section { get; set; }
        [Required]
        [Column("TRANSCRIPT_SEQ")]
        [StringLength(3)]
        public string TranscriptSeq { get; set; }
        [Required]
        [Column("ORG_CODE_ID")]
        [StringLength(10)]
        public string OrgCodeId { get; set; }
        [Column("WEEK_NUMBER")]
        [StringLength(3)]
        public string WeekNumber { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("END_DATE", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Column("EVENT_MED_NAME")]
        [StringLength(20)]
        public string EventMedName { get; set; }
        [Required]
        [Column("EVENT_LONG_NAME")]
        [StringLength(40)]
        public string EventLongName { get; set; }
        [Required]
        [Column("EVENT_TYPE")]
        [StringLength(4)]
        public string EventType { get; set; }
        [Column("CIP_CODE")]
        [StringLength(20)]
        public string CipCode { get; set; }
        [Column("SPEEDE_CODE")]
        [StringLength(20)]
        public string SpeedeCode { get; set; }
        [Column("SERIAL_ID")]
        [StringLength(30)]
        public string SerialId { get; set; }
        [Required]
        [Column("CREDIT_TYPE")]
        [StringLength(4)]
        public string CreditType { get; set; }
        [Column("CREDIT", TypeName = "numeric(6, 3)")]
        public decimal Credit { get; set; }
        [Column("CEU", TypeName = "numeric(6, 3)")]
        public decimal Ceu { get; set; }
        [Column("MINUTES_WEEK", TypeName = "numeric(6, 2)")]
        public decimal MinutesWeek { get; set; }
        [Column("CONTACT_HOURS", TypeName = "numeric(6, 2)")]
        public decimal ContactHours { get; set; }
        [Column("CREDIT_GRADE", TypeName = "numeric(6, 3)")]
        public decimal CreditGrade { get; set; }
        [Column("CREDIT_BILLING", TypeName = "numeric(6, 3)")]
        public decimal CreditBilling { get; set; }
        [Column("CREDIT_FTE", TypeName = "numeric(6, 3)")]
        public decimal CreditFte { get; set; }
        [Column("CREDIT_WORKLOAD", TypeName = "numeric(6, 3)")]
        public decimal CreditWorkload { get; set; }
        [Column("CREDIT_FED_FA", TypeName = "numeric(6, 3)")]
        public decimal CreditFedFa { get; set; }
        [Column("CREDIT_ST_FA", TypeName = "numeric(6, 3)")]
        public decimal CreditStFa { get; set; }
        [Column("CREDIT_CNTY_FA", TypeName = "numeric(6, 3)")]
        public decimal CreditCntyFa { get; set; }
        [Column("CREDIT_FED_RPT", TypeName = "numeric(6, 3)")]
        public decimal CreditFedRpt { get; set; }
        [Column("CREDIT_ST_RPT", TypeName = "numeric(6, 3)")]
        public decimal CreditStRpt { get; set; }
        [Column("CREDIT_CNTY_RPT", TypeName = "numeric(6, 3)")]
        public decimal CreditCntyRpt { get; set; }
        [Required]
        [Column("MID_GRADE")]
        [StringLength(4)]
        public string MidGrade { get; set; }
        [Required]
        [Column("FINAL_GRADE")]
        [StringLength(4)]
        public string FinalGrade { get; set; }
        [Column("FINAL_QUALITY_PNTS", TypeName = "numeric(8, 4)")]
        public decimal FinalQualityPnts { get; set; }
        [Required]
        [Column("REPEATED")]
        [StringLength(1)]
        public string Repeated { get; set; }
        [Column("REPEATED_YEAR")]
        [StringLength(4)]
        public string RepeatedYear { get; set; }
        [Column("REPEATED_TERM")]
        [StringLength(10)]
        public string RepeatedTerm { get; set; }
        [Column("REPEATED_SESSION")]
        [StringLength(10)]
        public string RepeatedSession { get; set; }
        [Column("REPEATED_ID")]
        [StringLength(15)]
        public string RepeatedId { get; set; }
        [Column("REPEATED_SUB_TYPE")]
        [StringLength(4)]
        public string RepeatedSubType { get; set; }
        [Column("REPEATED_SECTION")]
        [StringLength(4)]
        public string RepeatedSection { get; set; }
        [Required]
        [Column("COURSE_PRINT_RC")]
        [StringLength(1)]
        public string CoursePrintRc { get; set; }
        [Required]
        [Column("COURSE_PRINT_TRAN")]
        [StringLength(1)]
        public string CoursePrintTran { get; set; }
        [Required]
        [Column("ADD_DROP_WAIT")]
        [StringLength(1)]
        public string AddDropWait { get; set; }
        [Column("STATUS_DATE", TypeName = "datetime")]
        public DateTime StatusDate { get; set; }
        [Required]
        [Column("PREREG_REG_STATUS")]
        [StringLength(4)]
        public string PreregRegStatus { get; set; }
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
        [Column("CLASS_LEVEL_CREDITS", TypeName = "numeric(6, 3)")]
        public decimal ClassLevelCredits { get; set; }
        [Column("CONTACT_HR_SESSION", TypeName = "numeric(6, 2)")]
        public decimal ContactHrSession { get; set; }
        [Column("HONORS")]
        [StringLength(10)]
        public string Honors { get; set; }
        [Column("REFERENCE_EVENT_ID")]
        [StringLength(20)]
        public string ReferenceEventId { get; set; }
        [Column("REFERENCE_SUB_TYPE")]
        [StringLength(10)]
        public string ReferenceSubType { get; set; }
        [Column("ATTEND_STATUS")]
        [StringLength(4)]
        public string AttendStatus { get; set; }
        [Column("LAST_ATTEND_DATE", TypeName = "datetime")]
        public DateTime? LastAttendDate { get; set; }
        [Required]
        [Column("COMMENT_EXIST")]
        [StringLength(1)]
        public string CommentExist { get; set; }
        [Column("SPONSOR_CODE_ID")]
        [StringLength(10)]
        public string SponsorCodeId { get; set; }
        [Column("AGREEMENT_NUMBER")]
        public int? AgreementNumber { get; set; }
        [Column("REFERENCE_NUMBER_1")]
        [StringLength(100)]
        public string ReferenceNumber1 { get; set; }
        [Column("REFERENCE_NUMBER_2")]
        [StringLength(100)]
        public string ReferenceNumber2 { get; set; }
        [Column("STATUS_TIME", TypeName = "datetime")]
        public DateTime? StatusTime { get; set; }
        [Required]
        [Column("PROTECT_AGREEMENT_FLAG")]
        [StringLength(1)]
        public string ProtectAgreementFlag { get; set; }
        [Column("MILITARY_REFERENCE_CODE")]
        [StringLength(20)]
        public string MilitaryReferenceCode { get; set; }
        [Key]
        public int TranscriptDetailId { get; set; }
    }
}