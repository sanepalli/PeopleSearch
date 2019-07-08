angular.module("PeopleSearch")
.factory('peopleSearchFactory', function ($http) {

    var factory = {};
    var appPath = window.peopleSearch.applicationBase + '/api/';
   
    factory.getPersons = function (pageBody) {       
        var urlPath = appPath + 'PeopleSearch?searchString=' + '"' + pageBody.searchString + '"'
        return $http.get(urlPath, pageBody)
    }

    return factory;
     
});