var app = angular.module("ApplicationModule", ["ngRoute"]);

app.factory("ShareData", function () {
    return { value: 0 }
});

//Showing Routing  
app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/homepage',
        {
            templateUrl: 'Home/HomePage',
            controller: 'HomeController'
        });
    $routeProvider.when('/list',
        {
            templateUrl: 'Home/List',
            controller: 'ListController'
        });
    $routeProvider.otherwise(
        {
            redirectTo: '/'
        });

    $locationProvider.html5Mode(true).hashPrefix('!');
}]); 