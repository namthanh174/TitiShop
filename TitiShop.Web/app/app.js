/// <reference path="D:\Resource Web\ASP MVC\TitiShop\git\TitiShop.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('titishop', [
        'titishop.product_categories',
        'titishop.products',
        'titishop.common'
    ])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();