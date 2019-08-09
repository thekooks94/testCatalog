app.controller('addProductController', function ($scope, $http) {

    $scope.products = [];

    $http({
        method: "GET",
        url: "/api/catalog/getAllProducts"
    }).then(function mySuccess(response) {
        $scope.products = response;
    }, function myError(response) {

    });

    $scope.showModal = function () {
        document.getElementById('myModal').style.display = "block";
    };

    $scope.hideModal = function () {
        document.getElementById('myModal').style.display = "none";
    };

});  