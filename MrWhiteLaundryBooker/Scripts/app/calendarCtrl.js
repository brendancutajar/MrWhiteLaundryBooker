angular.module('LaundryBooker').controller("calendarCtrl", function ($scope, $http) {
    $scope.day = moment();

    this.setSelected = function (day) {
        $scope.day = day;
        console.log(day);
        if (confirm('Do you want to book a third of the day?')) {
            console.log('Yes!')
            $http.post('/api/bookings/', { Date: day.date, IsThirdOfDay: true })
                .then(function (response) {
                    console.log(response);
                }, function (response) {
                    console.error(response);
                    alert(response.data.ExceptionMessage);
                })
            ;
        } else {
            console.log('false');
        }
    }
});
