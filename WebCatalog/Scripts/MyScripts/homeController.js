app.controller('homeController', function ($scope, $http) {
   
    $scope.test = function () {
        $http({
            method: "GET",
            url: "/api/catalog/getAllProducts"
        }).then(function mySuccess(response) {
           
        }, function myError(response) {
           
        });
    };

});  