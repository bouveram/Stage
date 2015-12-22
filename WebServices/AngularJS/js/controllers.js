/// <reference path="angular.js" />
/// <reference path="angular-animate.js" />
/// <reference path="angular-route.js" />
/// <reference path="angular-resource.js" />
/// <reference path="services.js" />


(function () {
    var app = angular.module('PhonecatControllers', []);

    //PhonecatControllers.controller("PhoneDetailCtrl", ["$routeParams"], function ($routeParams) { this.phoneId = $routeParams.phoneId; });

    app.controller('FamilyListController',['Family', function (Family) {
        this.Families = [];
        this.Families = Family.query();
        //this.Families = Family.query();
        this.orderProp = 'Name';
        this.familySelection = '';
        this.input = '';
    }]);

    app.controller("ProductController", ['$http', '$routeParams', function ($http, $routeParams) {
        this.product = {};
        //this.product = Product.query();

        var c = this;
        var uri = 'products/' + $routeParams.productId + '.json';  //'http://localhost:54330/rest/product/' + $routeParams.productId;
        $http.get(uri).success(function (data) {
            c.product = data;
            //c.mainImageUrl = c.product.ImageUri;

        }).error(function (data, status) {
            alert("XHR Error " + uri + ": " + status);
        });
        
    }]);
    // Jusque ici

    app.controller("AboutController", ['Counter', function (Counter) {
        Counter.count();
        this.counter = Counter.getCount();
    }]
    );

})();
