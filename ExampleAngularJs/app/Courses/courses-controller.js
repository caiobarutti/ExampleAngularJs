'use strict';

app.controller("CoursesController", function ($scope, bootstrappedData) {
    $scope.courses = bootstrappedData.courses;
});