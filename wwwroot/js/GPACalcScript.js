var select = Array.from(document.getElementsByClassName('grade'));
var options = ["Select", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"];
var optValue = [0, 4.0, 3.75, 3.25, 3.0, 2.75, 2.25, 2.0, 1.75, 1.25, 1.0, 0.75, 0.0];
for (var i = 0; i < select.length; i++) {
    for (var j = 0; j < options.length; j++) {
        var option = document.createElement('option');
        option.text = options[j];
        option.value = optValue[j];
        select[i].append(option);
    }
}
function onHelpClick() {
    var toggleHelp = document.getElementById('help');
    if (toggleHelp.style.display === 'none') {
        toggleHelp.style.display = 'block';
    } else {
        toggleHelp.style.display = 'none';
    }
}
function delRow(button) {
    var tableBody = document.getElementById('tbody');
    var bodyRows = Array.from(tableBody.getElementsByTagName('tr'));
    if (bodyRows.length < 2) {
        alert("There must be at least 1 row for GPA Calculation!");
    } else {
        var tr = button.parentNode.parentNode;
        tr.parentNode.removeChild(tr);
    }
    updateRowIDs();
}
function insRow() {
    var tableBody = document.getElementById('tbody')
    var firstRow = tableBody.getElementsByTagName('tr')[0];
    var clonedRow = firstRow.cloneNode(true);
    clonedRow.getElementsByClassName('course')[0].value = "";
    clonedRow.getElementsByClassName('credit')[0].value = "";
    clonedRow.getElementsByClassName('grade')[0].SelectedValue = "Select";
    tableBody.appendChild(clonedRow);
    updateRowIDs();
}
function updateRowIDs() {
    var rowList = document.getElementById('tbody').getElementsByTagName('tr');
    var courseList = document.getElementsByClassName('course');
    var creditList = document.getElementsByClassName('credit');
    var gradeList = document.getElementsByClassName('grade');

    for (var i = 0; i < rowList.length; i++) {
        courseList[i].id = "course" + i;
        creditList[i].id = "credit" + i;
        gradeList[i].id = "grade" + i;
    }
}
function clrAll() {
    document.getElementById('curCredit').value = "";
    document.getElementById('curGPA').value = "";
    document.getElementById('calGPA').value = "";
    var rowList = document.getElementById('tbody').getElementsByTagName('tr');
    var courseList = document.getElementsByClassName('course');
    var creditList = document.getElementsByClassName('credit');
    var gradeList = document.getElementsByClassName('grade');

    for (var i = 0; i < rowList.length; i++) {
        courseList[i].value = "";
        creditList[i].value = "";
        gradeList[i].SelectedValue = "Select";
        gradeList[i].value = 0;
    }
}
function calculateGPA() {
    var curCredits = document.getElementById('curCredit').value;
    var curGPA = document.getElementById('curGPA').value;
    var calGPA = document.getElementById('calGPA');
    var rowList = document.getElementById('tbody').getElementsByTagName('tr');
    var creditList = document.getElementsByClassName('credit');
    var gradeList = document.getElementsByClassName('grade');
    var sumGrade = 0, sumCredit = 0, ttlGrade = 0, ttlCredit = 0, prodCurGrade = 0;

    for (var i = 0; i < rowList.length; i++) {
        sumGrade += (Number(creditList[i].value) * Number(gradeList[i].value));
        sumCredit += Number(creditList[i].value);
    }

    prodCurGrade = (Number(curCredits) * Number(curGPA));
    ttlGrade = sumGrade + prodCurGrade;
    ttlCredit = (sumCredit + Number(curCredits));
    calGPA.value = Number(ttlGrade / ttlCredit).toFixed(2);

    if (isNaN(calGPA.value)) {
        calGPA.value = "ERROR";
        calGPA.style.color = "red";
        alert("Please verify that all used rows are properly filled in or selected.");
    } else if (calGPA.value < 2.00) {
        calGPA.style.color = "red";
    } else if (calGPA.value > 2.00 && calGPA.value < 3.00) {
        calGPA.style.color = "yellow";
    } else {
        calGPA.style.color = "green";
    }
}