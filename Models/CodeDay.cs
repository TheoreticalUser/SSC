using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC.Models
{
    [Table("CODE_DAY")]
    public partial class CodeDay
    {
        [Key]
        [Column("CODE_VALUE_KEY")]
        [StringLength(4)]
        public string CodeValueKey { get; set; }
        [Column("CODE_VALUE")]
        [StringLength(4)]
        public string CodeValue { get; set; }
        [Required]
        [Column("SHORT_DESC")]
        [StringLength(10)]
        public string ShortDesc { get; set; }
        [Required]
        [Column("MEDIUM_DESC")]
        [StringLength(20)]
        public string MediumDesc { get; set; }
        [Required]
        [Column("LONG_DESC")]
        [StringLength(40)]
        public string LongDesc { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
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
        [Column("DAY_SUNDAY")]
        [StringLength(1)]
        public string DaySunday { get; set; }
        [Required]
        [Column("DAY_MONDAY")]
        [StringLength(1)]
        public string DayMonday { get; set; }
        [Required]
        [Column("DAY_TUESDAY")]
        [StringLength(1)]
        public string DayTuesday { get; set; }
        [Required]
        [Column("DAY_WEDNESDAY")]
        [StringLength(1)]
        public string DayWednesday { get; set; }
        [Required]
        [Column("DAY_THURSDAY")]
        [StringLength(1)]
        public string DayThursday { get; set; }
        [Required]
        [Column("DAY_FRIDAY")]
        [StringLength(1)]
        public string DayFriday { get; set; }
        [Required]
        [Column("DAY_SATURDAY")]
        [StringLength(1)]
        public string DaySaturday { get; set; }
        [Required]
        [Column("DAY_SORT")]
        [StringLength(7)]
        public string DaySort { get; set; }
        [Column("CODE_XVAL")]
        [StringLength(10)]
        public string CodeXval { get; set; }
        [Column("CODE_XDESC")]
        [StringLength(64)]
        public string CodeXdesc { get; set; }
        [Required]
        [Column("ABT_JOIN")]
        [StringLength(1)]
        public string AbtJoin { get; set; }
        [Column("BINARY_DAY_FIELD")]
        public int? BinaryDayField { get; set; }
    }
}