(function (app) {
    'use strict';
    app.factory('authData', [
        function () {
            var authDataFactory = {};

            var authentication = {
                isAuthenticated: false,
                userName: ""
            };

            authDataFactory.authenticationData = authentication;

            return authDataFactory;
        }

    ]);

})(angular.module('titishop.common'));