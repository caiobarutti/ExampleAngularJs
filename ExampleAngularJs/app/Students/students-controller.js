'use strict';

app.controller("StudentsController", function ($scope, bootstrappedData) {
    $scope.students = bootstrappedData.students;
});