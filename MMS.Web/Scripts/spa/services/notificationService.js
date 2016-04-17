(function (app) {
    'use strict';

    app.factory('notificationService', notificationService);

    notificationService.$inject = ['toaster'];

    function notificationService(toaster) {

        /*toastr.options = {
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "fadeIn": 300,
            "fadeOut": 1000,
            "timeOut": 3000,
            "extendedTimeOut": 1000
        };*/

        var service = {
            displaySuccess: displaySuccess,
            displayError: displayError,
            displayWarning: displayWarning,
            displayInfo: displayInfo,
            displayPleaseWaitInfo: displayPleaseWaitInfo
        };

        return service;

        function displaySuccess(message) {
            toaster.success(message);
        }

        function displayError(error) {
            if (Array.isArray(error)) {
                error.forEach(function (err) {
                    toaster.error(err);
                });
            } else {
                toaster.error(error);
            }
        }

        function displayWarning(message) {
            toaster.warning(message);
        }

        function displayInfo(message) {
            toaster.info(message);
        }

        function displayPleaseWaitInfo() {
            toaster.info("Please wait while we process your request!");
        }

    }

})(angular.module('common.core'));