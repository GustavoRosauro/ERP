let app = angular.module("ClienteApp", []);

app.controller("ClienteController", ($scope, $http) => {
    $http({
        method: "GET",
        url: "/ClientePJ/RetornaLista",
        data: {}
    }).then((dados) => {
        $scope.lista =  dados.data;
    });
});