var app = angular.module("app", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Registration/Courses', { templateUrl: '/templates/Courses/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Registration/Students', { templateUrl: '/templates/Students/students.html', controller: 'StudentsController' });
        $locationProvider.html5Mode(true);
    });