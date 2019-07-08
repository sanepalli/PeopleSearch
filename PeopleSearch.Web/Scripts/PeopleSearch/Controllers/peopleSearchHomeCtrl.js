var app = angular.module('PeopleSearch');
   
app.controller('peopleSearchHomeCtrl', ['$scope', '$routeParams', 'peopleSearchFactory', function ($scope, $routeParams, peopleSearchFactory) {
   
    $scope.appPath = window.peopleSearch.applicationPath;
    $scope.currentPersons = null;
    
     $scope.getPersons = function () {
        if (typeof ($scope.searchString) != "undefined" || $scope.searchString != "") {
            // show persons are being loaded
            $scope.personsLoading = true;           
            $scope.searchString = $scope.searchString
            
             $scope.pageBody = {
                searchString: $scope.searchString
            };

            peopleSearchFactory.getPersons($scope.pageBody).then(function (data) { 
                 $scope.currentPersons = data;
                 $scope.currentPersons = $scope.currentPersons.data; 
                $scope.personsLoading = false;  
            }); 
        };

    };
    
}
]);






