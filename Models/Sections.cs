using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SSC.Models
{
    [Table("SECTIONS")]
    [Index(nameof(SectionId), Name = "uqSections_SectionId", IsUnique = true)]
    public partial class Sections
    {
        [Key]
        [Column("ACADEMIC_YEAR")]
        [StringLength(4)]
        public string AcademicYear { get; set; }
        [Key]
        [Column("ACADEMIC_TERM")]
        [StringLength(10)]
        public string AcademicTerm { get; set; }
        [Key]
        [Column("ACADEMIC_SESSION")]
        [StringLength(10)]
        public string AcademicSession { get; set; }
        [Key]
        [Column("EVENT_ID")]
        [StringLength(15)]
        public string EventId { get; set; }
        [Key]
        [Column("EVENT_SUB_TYPE")]
        [StringLength(4)]
        public string EventSubType { get; set; }
        [Key]
        [Column("SECTION")]
        [StringLength(4)]
        public string Section { get; set; }
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
        [Required]
        [Column("ORG_CODE_ID")]
        [StringLength(10)]
        public string OrgCodeId { get; set; }
        [Required]
        [Column("PROGRAM")]
        [StringLength(6)]
        public string Program { get; set; }
        [Required]
        [Column("COLLEGE")]
        [StringLength(6)]
        public string College { get; set; }
        [Required]
        [Column("DEPARTMENT")]
        [StringLength(10)]
        public string Department { get; set; }
        [Required]
        [Column("CURRICULUM")]
        [StringLength(6)]
        public string Curriculum { get; set; }
        [Required]
        [Column("CLASS_LEVEL")]
        [StringLength(4)]
        public string ClassLevel { get; set; }
        [Required]
        [Column("NONTRAD_PROGRAM")]
        [StringLength(6)]
        public string NontradProgram { get; set; }
        [Required]
        [Column("POPULATION")]
        [StringLength(6)]
        public string Population { get; set; }
        [Required]
        [Column("EVENT_STATUS")]
        [StringLength(1)]
        public string EventStatus { get; set; }
        [Column("CIP_CODE")]
        [StringLength(20)]
        public string CipCode { get; set; }
        [Column("SPEEDE_CODE")]
        [StringLength(20)]
        public string SpeedeCode { get; set; }
        [Column("SERIAL_ID")]
        [StringLength(30)]
        public string SerialId { get; set; }
        [Column("ROOM_TYPE")]
        [StringLength(6)]
        public string RoomType { get; set; }
        [Required]
        [Column("CREDIT_TYPE")]
        [StringLength(4)]
        public string CreditType { get; set; }
        [Column("CREDITS", TypeName = "numeric(6, 2)")]
        public decimal Credits { get; set; }
        [Column("CEU", TypeName = "numeric(6, 2)")]
        public decimal Ceu { get; set; }
        [Column("MINUTES_WEEK", TypeName = "numeric(6, 2)")]
        public decimal MinutesWeek { get; set; }
        [Column("CONTACT_HOURS", TypeName = "numeric(6, 2)")]
        public decimal ContactHours { get; set; }
        [Required]
        [Column("REPORT_CARD_PRINT")]
        [StringLength(1)]
        public string ReportCardPrint { get; set; }
        [Required]
        [Column("TRANSCRIPT_PRINT")]
        [StringLength(1)]
        public string TranscriptPrint { get; set; }
        [Column("MIN_PARTICIPANT")]
        public int MinParticipant { get; set; }
        [Column("TARGET_PARTICIPANT")]
        public int TargetParticipant { get; set; }
        [Column("MAX_PARTICIPANT")]
        public int MaxParticipant { get; set; }
        [Required]
        [Column("OTHER_ORG")]
        [StringLength(1)]
        public string OtherOrg { get; set; }
        [Column("OTHER_ORG_PART")]
        public int OtherOrgPart { get; set; }
        [Required]
        [Column("OTHER_PROGRAM")]
        [StringLength(1)]
        public string OtherProgram { get; set; }
        [Column("OTHER_PROGRAM_PART")]
        public int OtherProgramPart { get; set; }
        [Required]
        [Column("OTHER_COLLEGE")]
        [StringLength(1)]
        public string OtherCollege { get; set; }
        [Column("OTHER_COLLEGE_PART")]
        public int OtherCollegePart { get; set; }
        [Required]
        [Column("OTHER_DEPARTMENT")]
        [StringLength(1)]
        public string OtherDepartment { get; set; }
        [Column("OTHER_DEPT_PART")]
        public int OtherDeptPart { get; set; }
        [Required]
        [Column("OTHER_CURRICULUM")]
        [StringLength(1)]
        public string OtherCurriculum { get; set; }
        [Column("OTHER_CURRIC_PART")]
        public int OtherCurricPart { get; set; }
        [Required]
        [Column("OTHER_CLASS_LEVEL")]
        [StringLength(1)]
        public string OtherClassLevel { get; set; }
        [Column("OTHER_CLEVEL_PART")]
        public int OtherClevelPart { get; set; }
        [Required]
        [Column("OTHER_NONTRAD")]
        [StringLength(1)]
        public string OtherNontrad { get; set; }
        [Column("OTHER_NONTRAD_PART")]
        public int OtherNontradPart { get; set; }
        [Required]
        [Column("OTHER_POPULATION")]
        [StringLength(1)]
        public string OtherPopulation { get; set; }
        [Column("OTHER_POP_PART")]
        public int OtherPopPart { get; set; }
        [Column("ADDS")]
        public int Adds { get; set; }
        [Column("DROPS")]
        public int Drops { get; set; }
        [Column("WAIT_LIST")]
        public int WaitList { get; set; }
        [Column("OTHER_ORG_ADD")]
        public int OtherOrgAdd { get; set; }
        [Column("OTHER_ORG_DROP")]
        public int OtherOrgDrop { get; set; }
        [Column("OTHER_ORG_WAIT")]
        public int OtherOrgWait { get; set; }
        [Column("OTHER_PROGRAM_ADD")]
        public int OtherProgramAdd { get; set; }
        [Column("OTHER_PROGRAM_DROP")]
        public int OtherProgramDrop { get; set; }
        [Column("OTHER_PROGRAM_WAIT")]
        public int OtherProgramWait { get; set; }
        [Column("OTHER_COLLEGE_ADD")]
        public int OtherCollegeAdd { get; set; }
        [Column("OTHER_COLLEGE_DROP")]
        public int OtherCollegeDrop { get; set; }
        [Column("OTHER_COLLEGE_WAIT")]
        public int OtherCollegeWait { get; set; }
        [Column("OTHER_DEPT_ADD")]
        public int OtherDeptAdd { get; set; }
        [Column("OTHER_DEPT_DROP")]
        public int OtherDeptDrop { get; set; }
        [Column("OTHER_DEPT_WAIT")]
        public int OtherDeptWait { get; set; }
        [Column("OTHER_CURR_ADD")]
        public int OtherCurrAdd { get; set; }
        [Column("OTHER_CURR_DROP")]
        public int OtherCurrDrop { get; set; }
        [Column("OTHER_CURR_WAIT")]
        public int OtherCurrWait { get; set; }
        [Column("OTHER_CLEVEL_ADD")]
        public int OtherClevelAdd { get; set; }
        [Column("OTHER_CLEVEL_DROP")]
        public int OtherClevelDrop { get; set; }
        [Column("OTHER_CLEVEL_WAIT")]
        public int OtherClevelWait { get; set; }
        [Column("OTHER_NONTRAD_ADD")]
        public int OtherNontradAdd { get; set; }
        [Column("OTHER_NONTRAD_DROP")]
        public int OtherNontradDrop { get; set; }
        [Column("OTHER_NONTRAD_WAIT")]
        public int OtherNontradWait { get; set; }
        [Column("OTHER_POP_ADD")]
        public int OtherPopAdd { get; set; }
        [Column("OTHER_POP_DROP")]
        public int OtherPopDrop { get; set; }
        [Column("OTHER_POP_WAIT")]
        public int OtherPopWait { get; set; }
        [Column("WEEK_NUMBER")]
        [StringLength(3)]
        public string WeekNumber { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("END_DATE", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Required]
        [Column("SEC_ENROLL_STATUS")]
        [StringLength(6)]
        public string SecEnrollStatus { get; set; }
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
        [Column("GENERAL_ED")]
        [StringLength(10)]
        public string GeneralEd { get; set; }
        [Column("CONTACT_HR_SESSION", TypeName = "numeric(6, 2)")]
        public decimal ContactHrSession { get; set; }
        [Required]
        [Column("MID_GRD_RECEIVED")]
        [StringLength(1)]
        public string MidGrdReceived { get; set; }
        [Required]
        [Column("FINAL_GRD_RECEIVED")]
        [StringLength(1)]
        public string FinalGrdReceived { get; set; }
        [Required]
        [Column("SCHEDULE_PRIORITY")]
        [StringLength(1)]
        public string SchedulePriority { get; set; }
        [Column("PUBLICATION_NAME_1")]
        [StringLength(100)]
        public string PublicationName1 { get; set; }
        [Column("PUBLICATION_NAME_2")]
        [StringLength(100)]
        public string PublicationName2 { get; set; }
        [Column("LATE_REG_FEE_DATE", TypeName = "datetime")]
        public DateTime? LateRegFeeDate { get; set; }
        [Column("REQUESTED_MEETINGS")]
        public int RequestedMeetings { get; set; }
        [Column("SCHEDULED_MEETINGS")]
        public int ScheduledMeetings { get; set; }
        [Required]
        [Column("ANONYMOUS_GRADING")]
        [StringLength(1)]
        public string AnonymousGrading { get; set; }
        [Column("CANCEL_REASON")]
        [StringLength(10)]
        public string CancelReason { get; set; }
        [Column("LAST_REFUND_DATE", TypeName = "datetime")]
        public DateTime? LastRefundDate { get; set; }
        [Column("ADJUSTMENT_POLICY_ID")]
        public int? AdjustmentPolicyId { get; set; }
        [Required]
        [Column("REPEATABLE")]
        [StringLength(1)]
        public string Repeatable { get; set; }
        [Required]
        [Column("ACTIVITY_TYPE_GRADING")]
        [StringLength(1)]
        public string ActivityTypeGrading { get; set; }
        [Required]
        [Column("REGISTRATION_TYPE")]
        [StringLength(10)]
        public string RegistrationType { get; set; }
        public int SectionId { get; set; }
        public byte AssignmentWeightingMethod { get; set; }
        public bool? UseWeightedAssignmentTypes { get; set; }
        public bool RequiresGradeApproval { get; set; }
        public bool HideOnlineSearch { get; set; }
    }
}