angular.module('LaundryBooker').directive('calendar', function () {
    return {
        restrict: 'E',
        templateUrl: '../Scripts/app/templates/calendar.html',
        require: '^ngController',
        scope: {
            selected : '='
        },
        link: function (scope, elem, attrs, parentController) {
            scope.selected = _removeTime(scope.selected || moment());
            scope.month = scope.selected.clone();
            var start = scope.selected.clone();
            _removeTime(start.startOf('week'));

            _buildMonth(scope, start, scope.month);

            scope.select = function (day) {
                if (day.date.month() === scope.month.month()) {
                    scope.selected = day.date;
                    parentController.setSelected(day);
                } else {
                    alert('You can anly select days in the current month')
                }
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
            date.add(1, 'w');
            done = count++ > 3;
            monthIndex = date.month();
        }
    }

    function _buildWeek(date, month) {
        var days = [];
        for (var i = 0; i < 7; i++) {
            days.push({
                name: date.format('dd').substring(0, 1),
                number: date.date(),
                isCurrentMonth: date.month() === month.month(),
                isToday: date.isSame(new Date(), 'day'),
                date: date
            });
            date = date.clone();
            date.add(1, 'd');
        }
        return days;
    }
});