let app = angular.module("ClientesAPP", []);

app.controller("ListaController", ($scope, $http) => {
    $http({
        method: "get",
        url: "/ClientePF/ListaClientes",
        data: {}
    }).then((dados) => {
        $scope.lista = dados.data;
        });
    $scope.Remover = (id) => {
        $http({
            method: "POST",
            url: "/ClientePF/Excluir/",
            data: {id:id}
        }).then(() => {
            window.location.reload();
        });
    };
});