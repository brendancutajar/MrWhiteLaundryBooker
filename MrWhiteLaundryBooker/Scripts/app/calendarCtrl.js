angular.module('LaundryBooker').controller("calendarCtrl", function ($scope) {
    $scope.day = moment();

    this.setSelected = function (day) {
        $scope.day = day;
        console.log(day);
        if (confirm('Do you want to book a third of the day?')) {
            console.log('Yes!')
        } else {
            console.log('false')
        }
    }
});
