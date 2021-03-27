var app = angular.module('personalApp', []);
app.controller('personalController', function ($scope, $http) {
    $scope.resultado = "hola";
    $http({
        url: 'https://localhost:44375/api/Personal',
        method:'Get'
    }).then(function (response) {
        $scope.resultado = response.data;
    })
})