
var GigsController = function (attendanceService) {

    var init = function (container) {
        $(container).on("click", ".js-toggle-attendance", toggleAttendance);
    };

    var button;

    var toggleAttendance = function (e) {
        button = $(e.target);

        if (button.hasClass("btn-default"))
            attendanceService.createAttendance(gigId, done, fail);
        else
            attendanceService.deleteAttendance(gigId, done, fail);

    };



    var done = function () {
        var text = (button.text() == "Going") ? "Going?" : "Going";

        button.toggleClass("btn-info").toggleClass("btn-default").text(text);
    };

    var fail = function () {
        console.log("Somthing is wrong");
    };

    return {
        init = init
    }
}(AttendanceService);
