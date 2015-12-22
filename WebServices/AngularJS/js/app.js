/// <reference path="angular.js" />
/// <reference path="angular-animate.js" />
/// <reference path="angular-route.js" />
/// <reference path="angular-resource.js" />


(function () {
    var app = angular.module("PhonecatApp", ["phonecatFilters",
                                             "phonecatAnimations",
                                             "ngRoute",
                                             "PhonecatControllers",
                                             "PhonecatServices",
                                             "PhonecatDirectives"]);

    app.config(['$routeProvider',
        function ($routeProvider) {
            $routeProvider.
            when('/products', {
                templateUrl: 'views/products.html',
            }).
            when('/product/:productId', {
                templateUrl: 'views/product.html',
            }).
            when('/phoneform/:phoneId', {
                templateUrl: 'views/phoneform.html',
            }).
            when('/about', {
                templateUrl: 'views/about.html',
            }).
            otherwise({
                redirectTo: '/products'
            });
        }
    ]);
    
})();

