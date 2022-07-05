using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC.Models
{
    [Table("ABT_SETTINGS")]
    public partial class AbtSettings
    {
        [Key]
        [Column("AREA_NAME")]
        [StringLength(64)]
        public string AreaName { get; set; }
        [Key]
        [Column("SECTION_NAME")]
        [StringLength(64)]
        public string SectionName { get; set; }
        [Key]
        [Column("LABEL_NAME")]
        [StringLength(64)]
        public string LabelName { get; set; }
        [Required]
        [Column("SETTING")]
        public string Setting { get; set; }
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
        [StringLength(8)]
        public string RevisionTerminal { get; set; }
        [Required]
        [Column("ABT_JOIN")]
        [StringLength(1)]
        public string AbtJoin { get; set; }
        [Column("DECIMAL_COLUMN", TypeName = "numeric(18, 6)")]
        public decimal? DecimalColumn { get; set; }
    }
}