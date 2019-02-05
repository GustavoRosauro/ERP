let app = angular.module("ClienteApp", []);

app.controller("ClienteController", ($scope, $http) => {
    $scope.ValidaCNPJ = (cnpj) => {
        $http({
            method: "POST",
            url: "/ClientePJ/Cnpj/",
            data: { cnpj: cnpj }
        }).then((dados) => {
            $scope.lista = [dados.data];
            });
    };
});