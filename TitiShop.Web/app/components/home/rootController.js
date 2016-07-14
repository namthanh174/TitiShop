(function (app) {
    app.controller('rootController', rootController);
    rootController.$inject = ['$scope', '$state', 'authData', 'loginService', 'authenticationService'];


    function rootController($scope,$state,authData,loginService,authenticationService) {
        $scope.logout = function () {
            loginService.logout();
            $state.go('login');
        }

        $scope.authentication = authData.authenticationData;
        authenticationService.validateRequest();
    }
})(angular.module('titishop'));