var app = angular.module("ApplicationModule", ["ngRoute"]);

//Showing Routing  
app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/catalog',
        {
            templateUrl: 'Home/Catalog',
            controller: 'catalogController'
        });
    $routeProvider.when('/addProduct',
        {
            templateUrl: 'Home/AddProduct',
            controller: 'addProductController'
        });
    $routeProvider.otherwise(
        {
            redirectTo: '/catalog'
        });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false}).hashPrefix('!');
}]); 