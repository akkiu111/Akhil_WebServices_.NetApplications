var myModule = angular.module('myModule', []);
    myModule.controller('myController', function ($scope, $http) {
        $http.get('http://localhost:50683/api/state/getstatesxml').then(function (response) {
            $scope.states = response.data;
            $scope.selectedStates = $scope.states[0];
        });
});

//myModule.controller('myCtrl', function ($scope) {
//    $scope.names = ["Emil", "Tobias", "Linus"];
//});