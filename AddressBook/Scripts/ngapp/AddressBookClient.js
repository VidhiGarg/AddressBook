var clientapp = angular.module('clientapp', []);

clientapp.controller('ContactsController', function ($scope, $http) {
    
$http.get('/api/Contacts')
.then(
    function onSuccess (response) {
        $scope.contacts = response.data;                    
    },
    function onError(response) {
        $scope.status = 'Unable to load contact data: ' + response.message;
        console.log($scope.status);
    }
);

$scope.contactClicked = function (id) {    
    $http.get('/api/Address/'+id)
    .then(
    function onSuccess(response) {
        $scope.addresses = response.data;
    },
    function onError(response) {
        $scope.status = 'Unable to load address data: ' + response.message;
        console.log($scope.status);
    }
);

};

});
