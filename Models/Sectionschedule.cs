using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC.Models
{
    [Table("SECTIONSCHEDULE")]
    public partial class Sectionschedule
    {
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
        [Column("DAY")]
        [StringLength(4)]
        public string Day { get; set; }
        [Column("START_TIME", TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column("END_TIME", TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        [Column("ORG_CODE_ID")]
        [StringLength(10)]
        public string OrgCodeId { get; set; }
        [Column("BUILDING_CODE")]
        [StringLength(6)]
        public string BuildingCode { get; set; }
        [Column("ROOM_ID")]
        [StringLength(6)]
        public string RoomId { get; set; }
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
        [Column("CALENDARDET_EVENT_KEY")]
        public int CalendardetEventKey { get; set; }
        [Key]
        [Column("SECTIONSCHEDULE_ID")]
        public int SectionscheduleId { get; set; }
    }
}