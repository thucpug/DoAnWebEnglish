/// <reference path="../../../Assets/angular/angular.js" />

(function () {
    angular.module('englishonline.lesson', ['englishonline.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {

        $stateProvider.state('lesson', {
            url: "/lesson",
            templateUrl: "/App_Center/Component/lesson_Categories/lessonView.html",
            controller: "lessonController"
        });
    }
})();