$(function () {
    $('#session').prop("selectedIndex", 0);
    $('#courseid').prop("selectedIndex", 0);
    $('#coursetype').prop("selectedIndex", 0);
    $('#coursesection').prop("selectedIndex", 0);
    $('#studentname').prop("selectedIndex", 0);
    $('#currentgrade').prop("selectedIndex", 0);
    $('#notified').prop("selectedIndex", 0);
    $('#conference').prop("selectedIndex", 0);
    $('#attends').prop("selectedIndex", 0);
    $('#engagement').prop("selectedIndex", 0);
    $('#homework').prop("selectedIndex", 0);
    $('#noncogissue').prop("selectedIndex", 0);
    $('#writing').prop("checked", false);
    $('#math').prop("checked", false);
    $('#science').prop("checked", false);
    $('#nurse').prop("checked", false);
    $('#txtComment').val('');

    $(function () {
        let arraySession = [];
        $.each(model, function (index, value) {
            arraySession.push(value.session);
        });

        arraySession = Array.from(new Set(arraySession));
        $.each(arraySession, function (index, value) {
            $('#session').append('<option value="' + value + '">' + value + '</option>');
        });
    });

    $('#session').change(function () {
        let selectedSession = this.options[this.selectedIndex].value;
        let arrayCourseID = [];
        let filteredData = model.filter(function (value) {
            return value.session === selectedSession;
        });
        $('#courseid').empty().append('<option value="">Select</option>');
        $('#coursetype').empty().append('<option value="">Select</option>');
        $('#coursesection').empty().append('<option value="">Select</option>');
        $('#studentname').empty().append('<option value="">Select</option>');
        $.each(filteredData, function (index, value) {
            arrayCourseID.push([value.courseNumber, value.courseName]);
        });
        arrayCourseID = Object.values(arrayCourseID.reduce((x, y) => (x[JSON.stringify(y)] = y, x), {}));
        $.each(arrayCourseID, function (index, value) {
            $('#courseid').append('<option value="' + value[0] + '~' + value[1] + '">' + value[0] + '</option>');
        });
    });

    $('#courseid').change(function () {
        let selectedCourseID = this.options[this.selectedIndex].value;
        selectedCourseID = selectedCourseID.slice(0, selectedCourseID.indexOf('~'));
        let arrayCourseType = [];
        let filterData = model.filter(function (value) {
            return value.courseNumber === selectedCourseID;
        });
        $('#coursetype').empty().append('<option value="">Select</option>');
        $('#coursesection').empty().append('<option value="">Select</option>');
        $('#studentname').empty().append('<option value="">Select</option>');
        $.each(filterData, function (index, value) {
            arrayCourseType.push(value.courseType);
        });
        arrayCourseType = Array.from(new Set(arrayCourseType));
        $.each(arrayCourseType, function (index, value) {
            $('#coursetype').append('<option value="' + value + '">' + value + '</option>');
        });
    });

    $('#coursetype').change(function () {
        let selectedCourseType = this.options[this.selectedIndex].value;
        let arrayCourseSection = [];
        let filterData = model.filter(function (value) {
            return value.courseType === selectedCourseType;
        });
        $('#coursesection').empty().append('<option value="">Select</option>');
        $('#studentname').empty().append('<option value="">Select</option>');
        $.each(filterData, function (index, value) {
            arrayCourseSection.push([value.section, value.sectionId]);
        });
        arrayCourseSection = Object.values(arrayCourseSection.reduce((x, y) => (x[JSON.stringify(y)] = y, x), {}));
        $.each(arrayCourseSection, function (index, value) {
            $('#coursesection').append('<option value="' + value[1] + '">' + value[0] + ' (' + value[1] + ') </option>');
        });
    });

    $('#coursesection').change(function () {
        let selectedCourseSection = this.options[this.selectedIndex].value;
        let arrayStudent = [];
        let filterData = model.filter(function (value) {
            return value.sectionId === selectedCourseSection;
        });
        $('#studentname').empty().append('<option value="">Select</option>');
        $.each(filterData, function (index, value) {
            arrayStudent.push([value.student, value.studentId]);
        });
        arrayStudent = Array.from(new Set(arrayStudent));
        $.each(arrayStudent, function (index, value) {
            $('#studentname').append('<option value="' + value[1] + '">' + value[0] + '</option>');
        });
    });
    jQuery.validator.setDefaults({
        debug: false,
        success: "valid"
    });
    $('#form').validate({
        rules: {
            'ASRPost.PeopleID': 'required',
            'ASRPost.Grade': 'required',
            'ASRPost.StudentNotification': 'required',
            'ASRPost.StudentConference': 'required',
            'ASRPost.Attendance': 'required',
            'ASRPost.Participation': 'required',
            'ASRPost.Homework': 'required',
            'ASRPost.NonCogIssues': 'required',
            'ASRPost.Comments': 'required'
        },
        messages: {
            'ASRPost.PeopleID': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.Grade': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.StudentNotification': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.StudentConference': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.Attendance': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.Participation': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.Homework': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.NonCogIssues': '<span style="color: red"> Selection is required!</span>',
            'ASRPost.Comments': '<span style="color: red"> Comment is required!</span>',
        },
        submitHandler: function (form) {
            form.submit();
            alert('Form has been submitted!');
        }
    });
});