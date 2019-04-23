(function (app) {
    app.controller('lessonController', lessonController);

    lessonController.$inject = ['$scope', 'apiService'];

    function lessonController($scope, apiService) {
        $scope.listLesson = [];

        $scope.getlistLesson = getlistLesson;

        function getlistLesson() {
            apiService.get('/api/lesson/getall', null, function (result) {
                $scope.listLesson = result.data;
            }, function () {
                console.log('Load listLesson failed.');
            });
        }

        $scope.getlistLesson();
    }
})(angular.module('englishonline.lesson'));