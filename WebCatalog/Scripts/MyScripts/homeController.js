app.controller('homeController', function ($scope, $http) {
   
    $scope.test = function () {
        $http({
            method: "GET",
            url: "/api/catalog/take"
        }).then(function mySuccess(response) {
           
        }, function myError(response) {
           
        });
    };

});  