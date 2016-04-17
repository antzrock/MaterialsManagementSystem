(function () {
    'use strict';

    angular.module('common.core', ['ngRoute', 'ngCookies', 'base64', 'angularValidator', 'toaster', 'ngAnimate', 'ngSanitize', 'LocalStorageModule'])
       .config(function (localStorageServiceProvider) {
           localStorageServiceProvider
           .setPrefix('mms')
            .setStorageType('localStorage')
            .setNotify(true, true);
           // localStorageServiceProvider.setStorageCookieDomain('example.com');
           // localStorageServiceProvider.setStorageType('sessionStorage');
       })

})();