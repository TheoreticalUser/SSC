using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SSC.Models
{
    [Keyless]
    [Table("_Academic_Status_Report_two")]
    public partial class AcademicStatusReportTwo
    {
        [Column("Trans_id", TypeName = "numeric(38, 0)")]
        public decimal? TransId { get; set; }
        [StringLength(50)]
        public string Sectionid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("Course_number")]
        [StringLength(15)]
        public string CourseNumber { get; set; }
        [Column("Course_title")]
        [StringLength(40)]
        public string CourseTitle { get; set; }
        [StringLength(50)]
        public string Instructor { get; set; }
        [StringLength(10)]
        public string Grade { get; set; }
        [Column("Student_notification")]
        [StringLength(50)]
        public string StudentNotification { get; set; }
        [Column("Student_conference")]
        [StringLength(50)]
        public string StudentConference { get; set; }
        [Column("Test_performance")]
        [StringLength(50)]
        public string TestPerformance { get; set; }
        [Column("Test_average")]
        [StringLength(50)]
        public string TestAverage { get; set; }
        [StringLength(50)]
        public string Participation { get; set; }
        [StringLength(50)]
        public string Attendance { get; set; }
        [StringLength(10)]
        public string Referal { get; set; }
        [Column("Referal_MS")]
        [StringLength(10)]
        public string ReferalMs { get; set; }
        [Column("Referal_SS")]
        [StringLength(10)]
        public string ReferalSs { get; set; }
        [Column("Referal_NS")]
        [StringLength(10)]
        public string ReferalNs { get; set; }
        [Column("noncog_issues")]
        [StringLength(50)]
        public string NoncogIssues { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [StringLength(50)]
        public string Peopleid { get; set; }
        [StringLength(16)]
        public string Homework { get; set; }
    }
}