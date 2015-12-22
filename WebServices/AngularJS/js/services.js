/// <reference path="angular-resource.js" />

var phonecatServices = angular.module('PhonecatServices', ['ngResource']);

phonecatServices.factory('Counter', function() {
	var s = {};              
	var i = 0;
             
	s.count = function() {
		i++;
	};
	
	s.getCount = function() {
		return i;
	}
                    
    return s;
});

phonecatServices.factory('Family', ['$resource', function ($resource) {
    return $resource('products/:family.json'/*'http://localhost:54330/rest/family/:family'*/, {}, {
        query: { method: 'GET', params: { family: 'list' }, isArray: true }
    });
}]);

phonecatServices.value('User', {
	user: {
		firstname: 'Cyril',
		lastname: 'Vincent',
    },
	role: 'admin'
});


var basket = function() {
	this.phones = [];
	
	this.add = function(p) {
		this.phones.push(p);
	}
	
	this.count = function() {
		return this.phones.length;
	}
}

phonecatServices.service('Basket', [basket]);

