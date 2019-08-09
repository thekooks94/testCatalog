app.controller('addProductController', function ($scope, $http) {

    $scope.product = { name: "", quantity: 1, description: "" };
    $scope.modal = { message: "Prodotto inserito correttamente" };

    $scope.addProduct = function () {
        $http({
            method: "POST",
            url: "/api/catalog/addProduct",
            data: $scope.product
        }).then(function mySuccess(response) {
            $scope.modal.message = "Prodotto inserito correttamente";
            $scope.hideModal();
            $scope.showModalEnd();
        }, function myError(response) {
            $scope.modal.message = response.data.exceptionMessage;
            $scope.hideModal();
            $scope.showModalEnd();
        });
    };

    $scope.showModal = function () {
        document.getElementById('myModal').style.display = "block";
    };

    $scope.hideModal = function () {
        document.getElementById('myModal').style.display = "none";
    };

    $scope.showModalEnd = function () {
        document.getElementById('myModalEnd').style.display = "block";
    };

    $scope.hideModalEnd = function () {
        document.getElementById('myModalEnd').style.display = "none";
    };

    $scope.enableButton = function () {
        if ($scope.product.name === undefined || $scope.product.name === "" || $scope.product.quantity === undefined || $scope.product.quantity === "" || $scope.product.quantity < 0) {
            document.getElementById("product-open-confirm").disabled = true;
        }
        else {
            document.getElementById("product-open-confirm").disabled = false;
        }
    };

});  