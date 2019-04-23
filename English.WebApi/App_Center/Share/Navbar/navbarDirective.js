/// <reference path="../../../Assets/angular/angular.js" />

(function (app) {
    'use strict';

    app.directive('navbarDirective', navbarDirective);

    function navbarDirective() {
        return {
            restrict: 'E',
            templateUrl: '/App_Center/Share/Navbar/navbarDirective.html',
           
        }
    }

})(angular.module('englishonline.common'));