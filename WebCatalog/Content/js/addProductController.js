app.controller('addProductController', function ($scope, $http) {

    $scope.products = [];

    $http({
        method: "GET",
        url: "/api/catalog/getAllProducts"
    }).then(function mySuccess(response) {
        console.log(response);
        $scope.products = response;
    }, function myError(response) {

    });


});  