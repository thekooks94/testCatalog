app.controller('catalogController', function ($scope, $http) {

    $scope.products = [];

    $http({
        method: "GET",
        url: "/api/catalog/getAllProducts"
    }).then(function mySuccess(response) {
        console.log(response.data);
        $scope.products = response.data;
        if ($scope.products === null || $scope.products.length === 0) {
            document.getElementById('no-products').style.display = "block";
        }
        else {
            document.getElementById('no-products').style.display = "none";
            }
        }, function myError(response) {
            document.getElementById('no-products').style.display = "block";
    });



});  