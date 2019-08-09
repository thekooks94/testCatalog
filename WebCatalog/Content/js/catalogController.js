app.controller('catalogController', function ($scope, $http) {

    $scope.products = [];

    function getCatalog() {
        $http({
            method: "GET",
            url: "/api/catalog/getAllProducts"
        }).then(function mySuccess(response) {
            $scope.products = response.data;
            if ($scope.products === null || $scope.products.length === 0) {
                if (document.getElementById('no-products') !== null)
                    document.getElementById('no-products').style.display = "block";
            }
            else {
                if (document.getElementById('no-products') !== null)
                document.getElementById('no-products').style.display = "none";
            }
        }, function myError(response) {
                if (document.getElementById('no-products') !== null)
                document.getElementById('no-products').style.display = "block";
        });
    }

    getCatalog();
    setInterval(getCatalog, 6000);

});  