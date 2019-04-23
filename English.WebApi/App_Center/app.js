/// <reference path="../Assets/angular/angular.js"/>


(function () {
    angular.module('englishonline',
        ['englishonline.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/Views/Home/Index.cshtml",
      
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();