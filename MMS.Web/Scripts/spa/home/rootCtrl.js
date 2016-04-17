(function (app) {
    'use strict';

    app.controller('rootCtrl', rootCtrl);

    rootCtrl.$inject = ['$scope', '$location', 'membershipService', '$rootScope', 'baseUrl', 'notificationService', 'localStorageService'];

    function rootCtrl($scope, $location, membershipService, $rootScope, baseUrl, notificationService, localStorageService) {

    }

})(angular.module('mms'));