var app = angular.module("ApplicationModule", ["ngRoute"]);

//Showing Routing  
app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/homepage',
        {
            templateUrl: 'Home/HomePage',
            controller: 'homeController'
        });
    $routeProvider.when('/list',
        {
            templateUrl: 'Home/List',
            controller: 'listController'
        });
    $routeProvider.otherwise(
        {
            redirectTo: '/'
        });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false}).hashPrefix('!');
}]); 