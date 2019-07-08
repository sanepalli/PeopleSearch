$window = window; //not allowed to inject services instances into angular configs.
angular.module('PeopleSearch', ['ngRoute'])

.config(['$routeProvider',
  function ($routeProvider) {
      var appPath = window.peopleSearch.applicationPath;
      $routeProvider
        .when('/', {
            templateUrl: appPath + '/Scripts/PeopleSearch/Templates/peopleSearch.html',
            controller: 'peopleSearchHomeCtrl'
        })
        .otherwise({
            templateUrl: appPath + '/Scripts/PeopleSearch/Templates/peopleSearch.html',
            controller: 'peopleSearchHomeCtrl'
        });
  }])
