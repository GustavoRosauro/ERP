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
    $scope.EnviaItens = (itens) => {
        $http({
            method: "POST",
            url: "/ClientePJ/Adicionar",
            data: itens
        }).then(() => {
            window.location.reload();
        });
    };
});