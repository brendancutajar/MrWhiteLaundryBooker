angular.module('LaundryBooker').controller("calendarCtrl", function ($scope, $http) {
    $scope.day = moment();

    this.setSelected = function (day) {
        $scope.day = day;
        console.log(day);
        if (confirm('Do you want to book a third of the day?')) {
            console.log('Yes!')
            $http.post('/api/bookings', { Date: day.date, IsThirdOfDay: true })
                .then(function (response) {
                    console.log(response);
                }, function (errorResponse) {
                    console.error(errorResponse);
                    alert(errorResponse.data.ExceptionMessage);
                })
            ;
        } else {
            console.log('false');
        }
        $scope.bookings = this.getBookings();
    }

    this.getBookings = function () {
        $http.get('/api/bookings')
            .then(function (response) {
                var bookings = {};
                $.get('api/bookingUsers')
                    .then(function (r) {
                        var bookings = response.data.map(function (booking) {
                            booking.isOwnBooking = r.UserName == booking.User.UserName;
                            return booking;
                        });
                        return bookings;
                    },
                    function (err) {
                        console.error(err)
                    })
            }, function (errorResponse) {
                console.error(errorResponse);
            });
    }

    $scope.bookings = this.getBookings();
});
