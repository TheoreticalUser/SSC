using Microsoft.EntityFrameworkCore;

namespace SSC.Models
{
    public partial class Campus6Context : DbContext
    {
        public Campus6Context()
        {
        }

        public Campus6Context(DbContextOptions<Campus6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AbtSettings> AbtSettings { get; set; }
        public virtual DbSet<AcademicStatusReportTwo> AcademicStatusReportTwo { get; set; }
        public virtual DbSet<CodeDay> CodeDay { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Sectionper> Sectionper { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Sectionschedule> Sectionschedule { get; set; }
        public virtual DbSet<Transcriptdetail> Transcriptdetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AbtSettings>(entity =>
            {
                entity.HasKey(e => new { e.AreaName, e.SectionName, e.LabelName })
                    .HasName("ABT_SETTINGS_PK");

                entity.HasComment("The ABT Settings (System) table holds institution defined settings. This table is designed similar to an ini file.");

                entity.Property(e => e.AreaName).HasComment("Area for the setting: Billing, Academic Records, etc.");

                entity.Property(e => e.SectionName).HasComment("Section within Area: Registration Section within Academic Records Area.");

                entity.Property(e => e.LabelName).HasComment("Setting within Section.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.DecimalColumn).HasComment("Depending on the particular setting, one of the columns in the row may be converted to this column.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.Setting).HasComment("Institution defined setting.");
            });

            modelBuilder.Entity<AcademicStatusReportTwo>(entity =>
            {
                entity.Property(e => e.Attendance).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CourseNumber).IsUnicode(false);

                entity.Property(e => e.CourseTitle).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength(true);

                entity.Property(e => e.Homework).IsUnicode(false);

                entity.Property(e => e.Instructor).IsUnicode(false);

                entity.Property(e => e.NoncogIssues).IsUnicode(false);

                entity.Property(e => e.Participation).IsUnicode(false);

                entity.Property(e => e.Peopleid).IsUnicode(false);

                entity.Property(e => e.Referal).IsUnicode(false);

                entity.Property(e => e.ReferalMs).IsUnicode(false);

                entity.Property(e => e.ReferalNs).IsUnicode(false);

                entity.Property(e => e.ReferalSs).IsUnicode(false);

                entity.Property(e => e.Sectionid).IsUnicode(false);

                entity.Property(e => e.StudentConference).IsUnicode(false);

                entity.Property(e => e.StudentNotification).IsUnicode(false);

                entity.Property(e => e.TestAverage).IsUnicode(false);

                entity.Property(e => e.TestPerformance).IsUnicode(false);
            });

            modelBuilder.Entity<CodeDay>(entity =>
            {
                entity.HasKey(e => e.CodeValueKey)
                    .HasName("C_DAY_PK");

                entity.HasComment("The Day of Week code table stores the days of the week when events, including courses, meetings, office hours, etc., can be held.");

                entity.HasIndex(e => e.CodeXval, "C_DAY_4X")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.LongDesc, e.CodeValueKey }, "C_DAY_L")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.MediumDesc, e.CodeValueKey }, "C_DAY_M")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ShortDesc, e.CodeValueKey }, "C_DAY_S")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.DaySort, e.CodeValueKey }, "C_DAY_SRT")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.CodeValue, "C_DAY_V")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CodeValueKey).HasComment("Day of Week code.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.BinaryDayField).HasComment("Binary Day Field");

                entity.Property(e => e.CodeValue).HasComment("Day of Week code.");

                entity.Property(e => e.CodeXdesc).HasComment("Corresponding code description for 4.x versions of ABT CAMPUS.");

                entity.Property(e => e.CodeXval).HasComment("Corresponding code value for 4.x versions of ABT CAMPUS.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.DayFriday).HasComment("Does class meet Friday?");

                entity.Property(e => e.DayMonday).HasComment("Does class meet Monday?");

                entity.Property(e => e.DaySaturday).HasComment("Does class meet Saturday?");

                entity.Property(e => e.DaySort).HasComment("Used by the programs to sort the days of the week. Number assigned programmatically. Monday = 1, Tuesday = 2, etc. MWF would = 135, TTh = 24.");

                entity.Property(e => e.DaySunday).HasComment("Does class meet Sunday?");

                entity.Property(e => e.DayThursday).HasComment("Does class meet Thursday?");

                entity.Property(e => e.DayTuesday).HasComment("Does class meet Tuesday?");

                entity.Property(e => e.DayWednesday).HasComment("Does class meet Wednesday?");

                entity.Property(e => e.LongDesc).HasComment("The long description of the code.");

                entity.Property(e => e.MediumDesc).HasComment("The medium description of the code.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.ShortDesc).HasComment("The short description of the code.");

                entity.Property(e => e.Status).HasComment("Status");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasKey(e => e.PeopleCodeId)
                    .HasName("PEOPLE_PK");

                entity.HasComment("The People table stores data related to ALL people, including students, faculty, alumni, parents, friends, etc.");

                entity.HasIndex(e => e.BirthDate, "PEOPLE_BIRTH_DATE")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.GovernmentId, "PEOPLE_GOV_ID")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.PeopleCode, e.PeopleId }, "PEOPLE_ID")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName, e.PeopleId }, "PEOPLE_NAME")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.PrevGovId, "PEOPLE_PREV_GOV_ID")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ReleaseInfo, "PEOPLE_RELEASE_INFO")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.PeopleCodeId).HasComment("People code of 'P' and ID.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.BirthCity).HasComment("City in which person was born.");

                entity.Property(e => e.BirthCountry).HasComment("Country where person was born.");

                entity.Property(e => e.BirthCounty).HasComment("County person was born in.");

                entity.Property(e => e.BirthDate).HasComment("Date of birth.");

                entity.Property(e => e.BirthState).HasComment("State in which person was born.");

                entity.Property(e => e.BirthZipCode).HasComment("Zip Code of where person was born.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.DeceasedDate).HasComment("Deceased date.");

                entity.Property(e => e.DeceasedFlag).HasComment("Deceased flag.");

                entity.Property(e => e.DisplayName).HasComment("The preferred display name of the person.");

                entity.Property(e => e.FirstName).HasComment("First name.");

                entity.Property(e => e.GenderIdentity).HasComment("The gender identity assigned to the person.");

                entity.Property(e => e.GovernmentId).HasComment("Government assigned ID number.");

                entity.Property(e => e.LastName).HasComment("Last Name.");

                entity.Property(e => e.LastNamePrefix).HasComment("The Last Name Prefix of a person.");

                entity.Property(e => e.LegalName).HasComment("The legal name of a person.");

                entity.Property(e => e.MiddleName).HasComment("Middle name.");

                entity.Property(e => e.Nickname).HasComment("The name in which the person is used to being addressed.");

                entity.Property(e => e.PeopleCode).HasComment("Always a P to designate a person.");

                entity.Property(e => e.PeopleId).HasComment("People ID. May be a government assigned ID number or an institution assigned ID.");

                entity.Property(e => e.PersonId)
                    .ValueGeneratedOnAdd()
                    .HasComment("Unique key to record.");

                entity.Property(e => e.PreferredAdd).HasComment("Preferres address examples: Home, Local, Parents. Address the person designates as their preferred choice for receiving mail.");

                entity.Property(e => e.Prefix).HasComment("Prefix.");

                entity.Property(e => e.PrevGovId).HasComment("Previous government assigned ID number.");

                entity.Property(e => e.PreviousId).HasComment("Previous ID.");

                entity.Property(e => e.PrimaryEmailId).HasComment("The ID of the primary email address of the person.");

                entity.Property(e => e.PrimaryPhoneId).HasComment("The person's primary phone, FK to PersonPhone.");

                entity.Property(e => e.Pronoun).HasComment("The pronoun assigned to the person.");

                entity.Property(e => e.ReleaseInfo).HasComment("Release information examples: Do not release any information, Release only to other schools.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.Suffix).HasComment("Suffix.");

                entity.Property(e => e.TaxId).HasComment("Person's Tax ID");
            });

            modelBuilder.Entity<Sectionper>(entity =>
            {
                entity.HasKey(e => new { e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.EventId, e.EventSubType, e.Section, e.PersonCodeId })
                    .HasName("SECTIONPER_PK");

                entity.HasComment("The Section Personnel table stores information about the Personnel who are responsible for a section.");

                entity.HasIndex(e => e.PersonCodeId, "SECTIONPER_PERSON")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AcademicYear).HasComment("Academic year of study.");

                entity.Property(e => e.AcademicTerm).HasComment("Term, Semester, Quarter, etc.");

                entity.Property(e => e.AcademicSession).HasComment("Sessions fall within the Academic Term. For example, in addition to the 15 week Fall Term, there may be three five week sessions.");

                entity.Property(e => e.EventId).HasComment("A unique identification for the section.");

                entity.Property(e => e.EventSubType).HasComment("Sub Type examples are: lecture, lab, self study.");

                entity.Property(e => e.Section).HasComment("Section is one specific offering of the event.");

                entity.Property(e => e.PersonCodeId).HasComment("ID number of personnel who is responsible for the section.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.Percentage).HasComment("Percentage of time the person is responsible for the section. There may be muliptle people responsible.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.HasKey(e => new { e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.EventId, e.EventSubType, e.Section })
                    .HasName("SECTIONS_PK");

                entity.HasComment("The Sections table stores the specific offerings of an event. If the section is found in the Event Table, the Event Table will act as a template and all information from the Event Table will default for the section.");

                entity.HasIndex(e => new { e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.EventMedName }, "SECTIONS_NAME")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.AcademicYear, e.AcademicTerm, e.OrgCodeId, e.Program, e.College, e.Department, e.Curriculum, e.EventId, e.EventSubType, e.Section, e.AcademicSession }, "SECTIONS_ORG_PCDC")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.SerialId }, "SECTIONS_SERIAL_ID")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.StartDate, e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.EventId, e.Credits, e.EventSubType, e.Section }, "SECTIONS_S_DATE_D")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AcademicYear).HasComment("Academic year of study.");

                entity.Property(e => e.AcademicTerm).HasComment("Term, Semester, Quarter, etc.");

                entity.Property(e => e.AcademicSession).HasComment("Sessions fall within the Academic Term. For example, in addition to the 15 week Fall Term, there may be three five week sessions.");

                entity.Property(e => e.EventId).HasComment("A unique identification for the section.");

                entity.Property(e => e.EventSubType).HasComment("Sub Type examples are: lecture, lab, self study.");

                entity.Property(e => e.Section).HasComment("Section is one specific offering of the event.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.ActivityTypeGrading)
                    .IsFixedLength(true)
                    .HasComment("Activity Type Grading");

                entity.Property(e => e.Adds).HasComment("The number people enrolled in this section.");

                entity.Property(e => e.AdjustmentPolicyId).HasComment("Adjustment Policy specific to Section.");

                entity.Property(e => e.AnonymousGrading).HasComment("Is the Section to be graded anonymously. The TranscriptGrading will have a pseudo ID assigned to each exam record. If the anonymous grading flag is Y, on IQ.WEB, the faculty member will only see the pseudo ID for entering the grade. ");

                entity.Property(e => e.AssignmentWeightingMethod)
                    .HasDefaultValueSql("((1))")
                    .HasComment("The method by which assignments are weighted: 1=Weight Assignments by possible points; 2=Weight Assignments by manually assigning weights; 3=Weight all assignemnts equally.");

                entity.Property(e => e.CancelReason).HasComment("Reason for canceling the section.");

                entity.Property(e => e.Ceu).HasComment("CEU is the unit of measure for Continuing Education experience. Normally ten contact hours.");

                entity.Property(e => e.CipCode).HasComment("CIP reference numbers may be entered here if necessary. CIP, Classification of Instructional Programming, may be obtained from the Board of Education.");

                entity.Property(e => e.ClassLevel).HasComment("Class Level designates number of credits the student has received.");

                entity.Property(e => e.College).HasComment("College is a branch of the institution. Examples: Nursing & Allied Health, Liberal Arts.");

                entity.Property(e => e.ContactHours).HasComment("Contact hours per week. This is not a duplication with Minutes per Week, since a class may meet for 50 minutes but contact hours may be 1.");

                entity.Property(e => e.ContactHrSession).HasComment("Contact hours per session.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreditType).HasComment("Credit type examples are: credit, audit, continuing ed, etc.");

                entity.Property(e => e.Credits).HasComment("Credits are the unit by which the institution measures its courses.");

                entity.Property(e => e.Curriculum).HasComment("Curriculum is a major or area in which the student will receive a degree.");

                entity.Property(e => e.Department).HasComment("Department falls within a College. Example: Liberal Arts College, Political Science Department.");

                entity.Property(e => e.Description).HasComment("Description of the section.");

                entity.Property(e => e.Drops).HasComment("The number of people who dropped this section.");

                entity.Property(e => e.EndDate).HasComment("The day the section ends.");

                entity.Property(e => e.EventLongName).HasComment("A 40 character description (name) defining the section.");

                entity.Property(e => e.EventMedName).HasComment("A 20 character description (name) defining the section.");

                entity.Property(e => e.EventStatus).HasComment("Status may be marked as Active or Inactive.");

                entity.Property(e => e.EventType).HasComment("The type of section is required. Types may be listed as courses, tests, seminars, conferences, etc.");

                entity.Property(e => e.FinalGrdReceived).HasComment("Have final grades been returned. As soon as the first final grade for the section is 'entered' on the system this flag will automatically become a 'Y'. NOTE: Only grades entered on the Grade Sheet will update the Final");

                entity.Property(e => e.GeneralEd).HasComment("The General Education Requirement which the course is a part of.");

                entity.Property(e => e.HideOnlineSearch).HasComment("Should this section hide on online search? 0 = No, 1 = Yes.");

                entity.Property(e => e.LastRefundDate).HasComment("Last Date a student would be eligible to receive a refund for dropping the course.");

                entity.Property(e => e.LateRegFeeDate).HasComment("Date when a student would receive a fee for registration. Fee must be set up under Assessment Rules. ");

                entity.Property(e => e.MaxParticipant).HasComment("Maximum participation for the section.");

                entity.Property(e => e.MidGrdReceived).HasComment("Have mid grades been returned. As soon as the first mid grade for this section is 'entered' on the system this flag will automatically become 'Y'. NOTE: Only grades entered on the Grade Sheet will update the Mid");

                entity.Property(e => e.MinParticipant).HasComment("Minimum participation required so the section is not cancelled.");

                entity.Property(e => e.MinutesWeek).HasComment("Minutes per week the section meets.");

                entity.Property(e => e.NontradProgram).HasComment("NonTraditional Program classifies a group of students who start and end a specified program together.");

                entity.Property(e => e.OrgCodeId).HasComment("The ID of the organization responsible for the section.");

                entity.Property(e => e.OtherClassLevel).HasComment("Should people from other class levels be allowed to participate in this section.");

                entity.Property(e => e.OtherClevelAdd).HasComment("The number of people from other class levels who are enrolled in this section.");

                entity.Property(e => e.OtherClevelDrop).HasComment("The number of people from other class levels who dropped this section.");

                entity.Property(e => e.OtherClevelPart).HasComment("The number of people from other class levels allowed to participate in this event. If it does not matter which class level the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherClevelWait).HasComment("The number of people from other class levels waiting to be enrolled in this section.");

                entity.Property(e => e.OtherCollege).HasComment("Should people in other colleges be allowed to participate in this section.");

                entity.Property(e => e.OtherCollegeAdd).HasComment("The number of people from other colleges who are enrolled in this section.");

                entity.Property(e => e.OtherCollegeDrop).HasComment("The number of people from other colleges who dropped this section.");

                entity.Property(e => e.OtherCollegePart).HasComment("The number of people from other colleges allowed to participate in this section. If it does not matter which college the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherCollegeWait).HasComment("The number of people from other colleges waiting to be enrolled in this section.");

                entity.Property(e => e.OtherCurrAdd).HasComment("The number of people from other curriculums who are enrolled in this section.");

                entity.Property(e => e.OtherCurrDrop).HasComment("The number of people from other curriculums who dropped this section.");

                entity.Property(e => e.OtherCurrWait).HasComment("The number of people from other curriculums waiting to be enrolled in this section.");

                entity.Property(e => e.OtherCurricPart).HasComment("The number of people from other curriculums allowed to participate in this section. If it does not matter which curriculum the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherCurriculum).HasComment("Should people in other curriculums be allowed to participate in this section.");

                entity.Property(e => e.OtherDepartment).HasComment("Should people in other departments be allowed to participate in this section.");

                entity.Property(e => e.OtherDeptAdd).HasComment("The number of people from other departments who are enrolled in this section.");

                entity.Property(e => e.OtherDeptDrop).HasComment("The number of people from other departments who dropped this section.");

                entity.Property(e => e.OtherDeptPart).HasComment("The number of people from other departments allowed to participate in this section. If it does not matter which department the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherDeptWait).HasComment("The number of people from other departments waiting to be enrolled in this section.");

                entity.Property(e => e.OtherNontrad).HasComment("Should people in other NonTraditional Programs be allowed to participate in this section.");

                entity.Property(e => e.OtherNontradAdd).HasComment("The number of people from other NonTraditional Programs who are enrolled in this section.");

                entity.Property(e => e.OtherNontradDrop).HasComment("The number of people from other NonTraditional Programs who dropped this section.");

                entity.Property(e => e.OtherNontradPart).HasComment("The number of people from other NonTraditional Programs allowed to participate in this section. If it does not matter which NonTraditional Program the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherNontradWait).HasComment("The number of people from other NonTraditional Programs waiting to be enrolled in this section.");

                entity.Property(e => e.OtherOrg).HasComment("Should people from other organizations be allowed to participate in this section.");

                entity.Property(e => e.OtherOrgAdd).HasComment("The number of people from other organizations who are enrolled in this section.");

                entity.Property(e => e.OtherOrgDrop).HasComment("The number of people from other organizations who dropped this section.");

                entity.Property(e => e.OtherOrgPart).HasComment("The number of people from other organizations who are allowed to participate in the section. If it does not matter which organization the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherOrgWait).HasComment("The number of people from other organizations waiting to be enrolled in this section.");

                entity.Property(e => e.OtherPopAdd).HasComment("The number of people from other populations who are enrolled in this section.");

                entity.Property(e => e.OtherPopDrop).HasComment("The number of people from other populations who dropped this section.");

                entity.Property(e => e.OtherPopPart).HasComment("The number of people from other populations allowed to participate in this section. If it does not matter which population the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherPopWait).HasComment("The number of people from other populations waiting to be enrolled in this section.");

                entity.Property(e => e.OtherPopulation).HasComment("Should people from other populations be allowed to participate in this section.");

                entity.Property(e => e.OtherProgram).HasComment("Should people in other programs be allowed to participate in this section.");

                entity.Property(e => e.OtherProgramAdd).HasComment("The number of people from other programs who are enrolled in this section.");

                entity.Property(e => e.OtherProgramDrop).HasComment("The number of people from other programs who dropped this section.");

                entity.Property(e => e.OtherProgramPart).HasComment("The number of people in other programs allowed to participate in this section. If it does not matter which program the person is from, this number should be the same as maximum participation.");

                entity.Property(e => e.OtherProgramWait).HasComment("The number of people from other programs waiting to be enrolled in this section.");

                entity.Property(e => e.Population).HasComment("Population designates the type of student. Examples: Regular, High School Student, Continuing Ed.");

                entity.Property(e => e.Program).HasComment("Program examples: Graduate, Undergraduate, Continuing Ed.");

                entity.Property(e => e.PublicationName1).HasComment("A 100 character text field that can be used in publications regarding the Section.");

                entity.Property(e => e.PublicationName2).HasComment("A 100 character text field that can be used in publications regarding the Section.");

                entity.Property(e => e.RegistrationType).HasComment("Type of registration, including 'TRAD' and 'CONED'.");

                entity.Property(e => e.Repeatable).HasComment("Is this course able to be repeated without triggering the repeat flag for the student to be set to Y. NOTE: if the previous course was failed, the current course will be flagged as repeated.");

                entity.Property(e => e.ReportCardPrint).HasComment("Should this section print on the report card.");

                entity.Property(e => e.RequestedMeetings).HasComment("Requested Meetings");

                entity.Property(e => e.RequiresGradeApproval).HasComment("Do grades entered by faculty for this section require approval by the department head?");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RoomType).HasComment("Room type that is required for the section: lecture hall, biology lab, etc.");

                entity.Property(e => e.SchedulePriority).HasComment("Schedule Priority");

                entity.Property(e => e.ScheduledMeetings).HasComment("Scheduled Meetings");

                entity.Property(e => e.SecEnrollStatus).HasComment("Enrollment Status of Section: Open, Minimum participation met, Target participation met, Closed(Reserves) or Closed.");

                entity.Property(e => e.SectionId)
                    .ValueGeneratedOnAdd()
                    .HasComment("Unique key to record.");

                entity.Property(e => e.SerialId).HasComment("Unique identification to serialize the ID, used for Telephone Registration or to give a unique ID for every section.");

                entity.Property(e => e.SpeedeCode).HasComment("SPEEDE reference numbers may be entered here if necessary. SPEEDE may be obtained from AACRAO.");

                entity.Property(e => e.StartDate).HasComment("The day the section starts.");

                entity.Property(e => e.TargetParticipant).HasComment("Optimum participation for the section.");

                entity.Property(e => e.TranscriptPrint).HasComment("Should this section print on the transcript.");

                entity.Property(e => e.UseWeightedAssignmentTypes)
                    .HasComputedColumnSql("(CONVERT([bit],case when [ACTIVITY_TYPE_GRADING]='Y' then 'TRUE' else 'FALSE' end,(0)))", false)
                    .HasComment("Should assignments of the same type (homework, quiz, report) be weighted collectively?");

                entity.Property(e => e.WaitList).HasComment("The number of people waiting to be enrolled in this section.");

                entity.Property(e => e.WeekNumber).HasComment("Week Number within the Academic Term the section starts.");
            });

            modelBuilder.Entity<Sectionschedule>(entity =>
            {
                entity.HasComment("The Section Schedule table stores the time and location for a section.");

                entity.HasIndex(e => new { e.AcademicYear, e.AcademicTerm, e.AcademicSession, e.EventId, e.EventSubType, e.Section, e.Day, e.StartTime }, "ixSectionSchedule")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.SectionscheduleId).HasComment("Identity key column");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.AcademicSession).HasComment("Sessions fall within the Academic Term. For example, in addition to the 15 week Fall Term, there may be three five week sessions.");

                entity.Property(e => e.AcademicTerm).HasComment("Term, Semester, Quarter, etc.");

                entity.Property(e => e.AcademicYear).HasComment("Academic year of study.");

                entity.Property(e => e.BuildingCode).HasComment("Building where the section is held.");

                entity.Property(e => e.CalendardetEventKey).HasComment("Calendardet Event Key");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.Day).HasComment("Day of the week. Days can be combined into one code. Example Monday, Wednesday and Friday can be coded as MWF.");

                entity.Property(e => e.EndTime).HasComment("End time for the section.");

                entity.Property(e => e.EventId).HasComment("A unique identification for the section.");

                entity.Property(e => e.EventSubType).HasComment("Sub Type examples are: lecture, lab, self study.");

                entity.Property(e => e.OrgCodeId).HasComment("Organization where the section is scheduled.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RoomId).HasComment("Room where the section is held.");

                entity.Property(e => e.Section).HasComment("Section is one specific offering of the event.");

                entity.Property(e => e.StartTime).HasComment("Start time for the section.");
            });

            modelBuilder.Entity<Transcriptdetail>(entity =>
            {
                entity.HasComment("The Transcript Detail Table holds the courses, seminars, etc. the student has taken over his/her academic career with the institution.");

                entity.Property(e => e.TranscriptDetailId).HasComment("Unique key to record.");

                entity.Property(e => e.AbtJoin).HasComment("Always an asterisk '*'.");

                entity.Property(e => e.AcademicSession).HasComment("Sessions fall within the Academic Term. For example, in addition to the 15 week Fall Term, there may be three five week sessions.");

                entity.Property(e => e.AcademicTerm).HasComment("Term, Semester, Quarter, etc.");

                entity.Property(e => e.AcademicYear).HasComment("Academic year of study.");

                entity.Property(e => e.AddDropWait).HasComment("Add/Drop/Wait List Status.");

                entity.Property(e => e.AgreementNumber).HasComment("Agreement Number");

                entity.Property(e => e.AttendStatus).HasComment("Attendance status for the course.");

                entity.Property(e => e.Ceu).HasComment("CEU is the unit of measure for Continuing Education experience. Normally ten contact hours.");

                entity.Property(e => e.CipCode).HasComment("CIP reference numbers may be entered here if necessary. CIP, Classification of Instructional Programming, may be obtained from the Board of Education.");

                entity.Property(e => e.ClassLevelCredits).HasComment("Credits used to determine the student's class level. At registration, class level credits are the grade credits. When a grade is entered, the class level credits are recalculated based upon the grade.");

                entity.Property(e => e.CommentExist).HasComment("Indicates if a comment for this student and course exist in the Transcript Comment table.");

                entity.Property(e => e.ContactHours).HasComment("Contact hours per week. This is not a duplication with Minutes per Week, since a class may meet for 50 minutes but contact hours may be 1.");

                entity.Property(e => e.ContactHrSession).HasComment("Contact hours per session.");

                entity.Property(e => e.CoursePrintRc).HasComment("Print the course on the report card.");

                entity.Property(e => e.CoursePrintTran).HasComment("Print the event on the Transcript.");

                entity.Property(e => e.CreateDate).HasComment("Row (record) create date. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateOpid).HasComment("Row (record) create operator. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTerminal).HasComment("Row (record) create terminal. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.CreateTime).HasComment("Row (record) create time. Updated automatically when the row is created. No keyboard access.");

                entity.Property(e => e.Credit).HasComment("Credits are the unit by which the institution measures its courses.");

                entity.Property(e => e.CreditBilling).HasComment("Low credit amount for billing.");

                entity.Property(e => e.CreditCntyFa).HasComment("Low credit amount for county financial aid.");

                entity.Property(e => e.CreditCntyRpt).HasComment("Low credit amount for county reporting.");

                entity.Property(e => e.CreditFedFa).HasComment("Low credit amount for federal financial aid.");

                entity.Property(e => e.CreditFedRpt).HasComment("Low credit amount for federal reporting.");

                entity.Property(e => e.CreditFte).HasComment("Low credit amount for FTE.");

                entity.Property(e => e.CreditGrade).HasComment("Low credit amount for grade.");

                entity.Property(e => e.CreditStFa).HasComment("Low credit amount for state financial aid.");

                entity.Property(e => e.CreditStRpt).HasComment("Low credit amount for state reporting.");

                entity.Property(e => e.CreditType).HasComment("Credit type examples are: credit, audit, continuing ed, etc.");

                entity.Property(e => e.CreditWorkload).HasComment("Low credit amount for workload reporting.");

                entity.Property(e => e.EndDate).HasComment("The day the event ends.");

                entity.Property(e => e.EventId).HasComment("A unique identification.");

                entity.Property(e => e.EventLongName).HasComment("A 40 character description (name) defining the event.");

                entity.Property(e => e.EventMedName).HasComment("A 20 character description (name) defining the event.");

                entity.Property(e => e.EventSubType).HasComment("Sub Type examples are: lecture, lab, self study.");

                entity.Property(e => e.EventType).HasComment("Types may be listed as courses, tests, seminars, conferences, etc.");

                entity.Property(e => e.FinalGrade).HasComment("Final grade.");

                entity.Property(e => e.FinalQualityPnts).HasComment("Final quality points. Determined by the grade.");

                entity.Property(e => e.Honors).HasComment("Honors received with the course.");

                entity.Property(e => e.LastAttendDate).HasComment("Last day of attendance for the course.");

                entity.Property(e => e.MidGrade).HasComment("Mid session grade.");

                entity.Property(e => e.MilitaryReferenceCode).HasComment("Validation code provided by the military to be used during registration in case of a military sponsorship");

                entity.Property(e => e.MinutesWeek).HasComment("Minutes per week the event meets.");

                entity.Property(e => e.OrgCodeId).HasComment("Institution (CAMPUS) that offered the event. This defaults from the Event Table to the Sections table. If no campus was specified on the Catalog window, the default campus set up in System Setup for 'This Campus ID' will be used.");

                entity.Property(e => e.PeopleCode).HasComment("Always a P to designate a person.");

                entity.Property(e => e.PeopleCodeId).HasComment("People code of 'P' and ID.");

                entity.Property(e => e.PeopleId).HasComment("People ID. May be a government assigned ID number or an institution assigned ID.");

                entity.Property(e => e.PreregRegStatus).HasComment("Registration Status is automatically updated to Preregistered or Registered depending on the day the course is added.");

                entity.Property(e => e.ProtectAgreementFlag)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true)
                    .HasComment("Y/N flag to determine if the Agreement_Number column is protected from changes by an automatic process. Default = 'N'");

                entity.Property(e => e.ReferenceEventId).HasComment("If the course is a transfer course, the ID number of the transfer institution course is entered here.");

                entity.Property(e => e.ReferenceNumber1).HasComment("P. O. Number");

                entity.Property(e => e.ReferenceNumber2).HasComment("Reference Number");

                entity.Property(e => e.ReferenceSubType).HasComment("Sub Type examples are: lecture, lab self study. If the course is a transfer course, the course's sub type is entered here.");

                entity.Property(e => e.Repeated).HasComment("Yes if repeated.");

                entity.Property(e => e.RepeatedId).HasComment("Identification of repeated course.");

                entity.Property(e => e.RepeatedSection).HasComment("Section of repeated course.");

                entity.Property(e => e.RepeatedSession).HasComment("Academic Session of repeated course.");

                entity.Property(e => e.RepeatedSubType).HasComment("Sub Type of repeated course.");

                entity.Property(e => e.RepeatedTerm).HasComment("Academic Term of repeated course.");

                entity.Property(e => e.RepeatedYear).HasComment("Academic year of repeated course.");

                entity.Property(e => e.RevisionDate).HasComment("Row (record) revision date. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionOpid).HasComment("Row (record) revision operator. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTerminal).HasComment("Row (record) revision terminal. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.RevisionTime).HasComment("Row (record) revision time. Updated automatically when the row is revised. No keyboard access.");

                entity.Property(e => e.Section).HasComment("Section is one specific offering of the event.");

                entity.Property(e => e.SerialId).HasComment("Unique identification to serialize the ID, used for Telephone Registration, or to give a unique ID to each section.");

                entity.Property(e => e.SpeedeCode).HasComment("SPEEDE reference numbers may be entered here if necssary. SPEEDE may be obtained from AACRAO.");

                entity.Property(e => e.SponsorCodeId).HasComment("Sponsor Code ID");

                entity.Property(e => e.StartDate).HasComment("The day the event starts.");

                entity.Property(e => e.StatusDate).HasComment("Date of Add/Drop/Wait List change.");

                entity.Property(e => e.StatusTime)
                    .HasDefaultValueSql("(getdate()-datediff(day,(0),getdate()))")
                    .HasComment("Time of Add/Drop/Wait List change.");

                entity.Property(e => e.TranscriptSeq).HasComment("Transcript sequence designates which transcript this record is associated with.");

                entity.Property(e => e.WeekNumber).HasComment("Week number within the Academic Term the section starts.");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}