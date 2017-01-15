angular.module('LaundryBooker').directive('calendar', function () {
    return {
        restrict: 'E',
        templateUrl: '../Scripts/app/templates/calendar.html',
        scope: {
            selected : '@'
        },
        link: function (scope) {
            scope.selected = _removeTime(scope.selected || moment());
            scope.month = scope.selected.clone();
            var start = scope.selected.clone();
            //start.date(1);
            //_removeTime(start.day(0));
            _removeTime(start.startOf('week'));

            _buildMonth(scope, start, scope.month);

            scope.select = function (day) {
                scope.selected = day.date;
            };           
        }
    }

    function _removeTime(date) {
        return date.day(0).hour(0).minute(0).second(0).millisecond(0);
    }

    function _buildMonth(scope, start, month) {
        scope.weeks = [];
        var done = false, date = start.clone(), monthIndex = date.month(), count = 0;
        while (!done) {
            scope.weeks.push({ days: _buildWeek(date.clone(), month) });
            date.add(1, "w");
            done = count++ > 3;//&& monthIndex !== date.month();
            monthIndex = date.month();
        }
    }

    function _buildWeek(date, month) {
        var days = [];
        for (var i = 0; i < 7; i++) {
            days.push({
                name: date.format("dd").substring(0, 1),
                number: date.date(),
                isCurrentMonth: date.month() === month.month(),
                isToday: date.isSame(new Date(), "day"),
                date: date
            });
            date = date.clone();
            date.add(1, "d");
        }
        return days;
    }
});