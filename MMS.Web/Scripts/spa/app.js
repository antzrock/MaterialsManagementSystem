(function () {
    'use strict';

    angular.module('mms', ['common.core', 'common.ui'])
        .config(config)
        .run(run)
        .run(function (editableOptions) {
            editableOptions.theme = 'bs2';
        })
        .constant('baseUrl', {
            //web: 'http://ANTZROCK-PC:37799/',
            web: 'http://localhost:37799/',
        });

    config.$inject = ['$routeProvider', '$locationProvider'];
    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "scripts/spa/account/login.html",
                controller: "loginCtrl"
            })
        .when("/dashboard", {
            templateUrl: "scripts/spa/dashboard/dashboard.html",
            controller: "dashboardCtrl"
        })
        .otherwise({ redirectTo: "/" });
    
        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode(true);
        }
    }

    run.$inject = ['$rootScope', '$location', '$cookieStore', '$http'];

    function run($rootScope, $location, $cookieStore, $http) {
        // handle page refreshes
        $rootScope.repository = $cookieStore.get('repository') || {};
        if ($rootScope.repository.loggedUser) {
            $http.defaults.headers.common['Authorization'] = $rootScope.repository.loggedUser.authdata;
        }
    }

})();