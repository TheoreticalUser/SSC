using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSC.Pages {

    public class ASRModel : PageModel {
        private readonly Campus6Context _context;
        public ASRModel(Campus6Context context) {
            _context = context;
        }
        [BindProperty(SupportsGet = true)] public string Id { get; set; }
        [BindProperty] public AcademicStatusReportTwo ASR2 { get; set; }
        public IQueryable<ASRViewModel> ASRView { get; set; }
        [BindProperty] public ASRPostModel ASRPost { get; set; }
        public string DistinctInstructor { get; set; }

        public string DistinctCurrentSemester { get; set; }
        public IActionResult OnGet() {
            if (Request.Cookies["SelfService"] == null) {
                return new RedirectToPageResult("/Error");
            }
            ASRView = GetASRData(Id);
            DistinctInstructor = ASRView.FirstOrDefault().Instructor.ToString();
            DistinctCurrentSemester = ASRView.FirstOrDefault().CurrentSemester.ToString();
            return Page();
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            try {
                ASR2.TransId = null;
                ASR2.Sectionid = ASRPost.SectionID;
                ASR2.TimeStamp = System.DateTime.Now;
                ASR2.CourseNumber = ASRPost.CourseID.Substring(0, ASRPost.CourseID.IndexOf("~"));
                ASR2.CourseTitle = ASRPost.CourseID[(ASRPost.CourseID.IndexOf("~") + 1)..];
                ASR2.Instructor = ASRPost.Instructor;
                ASR2.Grade = ASRPost.Grade;
                ASR2.StudentNotification = ASRPost.StudentNotification;
                ASR2.StudentConference = ASRPost.StudentConference;
                ASR2.TestPerformance = "";
                ASR2.TestAverage = "";
                ASR2.Participation = ASRPost.Participation;
                ASR2.Attendance = ASRPost.Attendance;
                ASR2.Referal = ASRPost.BoolToBinary(ASRPost.Referal);
                ASR2.ReferalMs = ASRPost.BoolToBinary(ASRPost.ReferalMs);
                ASR2.ReferalSs = ASRPost.BoolToBinary(ASRPost.ReferalNs);
                ASR2.ReferalNs = ASRPost.BoolToBinary(ASRPost.ReferalNs);
                ASR2.NoncogIssues = ASRPost.NonCogIssues;
                ASR2.Comments = ASRPost.Comments;
                ASR2.Peopleid = ASRPost.PeopleID;
                ASR2.Homework = ASRPost.Homework;
                _context.AcademicStatusReportTwo.Add(ASR2);
                _context.SaveChanges();
            } catch (Exception e) {
                return new RedirectToPageResult("/Error", e);
            }
            return OnGet();
        }

        public IQueryable<ASRViewModel> GetASRData(string id) {
            return
                from sp in _context.Set<Sectionper>()
                join cy in _context.Set<AbtSettings>()
                    on sp.AcademicYear equals cy.Setting
                join ct in _context.Set<AbtSettings>()
                    on sp.AcademicTerm equals ct.Setting
                join s in _context.Set<Sections>()
                    on new { sp.AcademicYear, sp.AcademicTerm, sp.AcademicSession, sp.EventId, sp.EventSubType, sp.Section }
                    equals new { s.AcademicYear, s.AcademicTerm, s.AcademicSession, s.EventId, s.EventSubType, s.Section }
                join t in _context.Set<Transcriptdetail>()
                    on new { s.AcademicYear, s.AcademicTerm, s.AcademicSession, s.EventId, s.EventSubType, s.Section }
                    equals new { t.AcademicYear, t.AcademicTerm, t.AcademicSession, t.EventId, t.EventSubType, t.Section }
                join p in _context.Set<People>()
                    on t.PeopleCodeId equals p.PeopleCodeId
                join i in _context.Set<People>()
                    on sp.PersonCodeId equals i.PeopleCodeId
                where cy.LabelName == "CURRENT_YEAR"
                    && ct.LabelName == "CURRENT_TERM"
                    && s.EventStatus == "a"
                    && t.AddDropWait == "a"
                    && sp.PersonCodeId == id
                select new ASRViewModel(
                    i.FirstName + " " + i.LastName,
                    sp.AcademicTerm + " " + sp.AcademicYear,
                    sp.AcademicSession,
                    sp.EventId,
                    t.EventLongName,
                    sp.EventSubType,
                    sp.Section,
                    s.SectionId.ToString(),
                    p.PeopleCodeId,
                    p.FirstName + " " + p.LastName
                );
        }
    }

    public class ASRViewModel {

        public ASRViewModel() {
        }
        public ASRViewModel(string instructor, string currentSemester, string session, string courseNumber, string courseName,
            string courseType, string section, string sectionId, string studentId, string student) {
            Instructor = instructor;
            CurrentSemester = currentSemester;
            Session = session;
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseType = courseType;
            Section = section;
            SectionId = sectionId;
            StudentId = studentId;
            Student = student;
        }

        public string Instructor { get; set; }
        public string CurrentSemester { get; set; }
        public string Session { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public string Section { get; set; }
        public string SectionId { get; set; }
        public string StudentId { get; set; }
        public string Student { get; set; }
    }

    public class ASRPostModel {
        public string BoolToBinary(string value) {
            if (value == "true") {
                return "1";
            } else {
                return "0";
            }
        }

        public string Instructor { get; set; }
        public string CourseID { get; set; }
        public string SectionID { get; set; }
        public string PeopleID { get; set; }
        public string Grade { get; set; }
        public string StudentNotification { get; set; }
        public string StudentConference { get; set; }
        public string Attendance { get; set; }
        public string Homework { get; set; }
        public string Participation { get; set; }
        public string NonCogIssues { get; set; }
        public string Referal { get; set; }
        public string ReferalMs { get; set; }
        public string ReferalSs { get; set; }
        public string ReferalNs { get; set; }
        public string Comments { get; set; }
    }
}