using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC.Models
{
    [Table("SECTIONPER")]
    public partial class Sectionper
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
        [Key]
        [Column("PERSON_CODE_ID")]
        [StringLength(10)]
        public string PersonCodeId { get; set; }
        [Column("PERCENTAGE", TypeName = "numeric(6, 3)")]
        public decimal Percentage { get; set; }
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
    }
}