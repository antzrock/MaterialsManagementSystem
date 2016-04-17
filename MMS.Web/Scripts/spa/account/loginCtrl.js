(function (app) {
    'use strict';

    app.controller('loginCtrl', loginCtrl);

    loginCtrl.$inject = ['$scope', 'membershipService', 'notificationService', '$rootScope', '$location', 'localStorageService'];

    function loginCtrl($scope, membershipService, notificationService, $rootScope, $location, localStorageService) {

    }

})(angular.module('common.core'));