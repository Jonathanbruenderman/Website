angular.module('Grid')
.directive('grid', function () {
    return {
        restrict: 'A',
        require: 'ngModel',
        scope: {
            ngModel: '='
        },
        templateUrl: 'C:\MySite\Website\Web.portfolio1\Views/Home/grid.cshtml'
    };
});