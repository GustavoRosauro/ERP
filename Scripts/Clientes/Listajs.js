function somenteNumeros(num) {
    var er = /[^0-9.]/;
    er.lastIndex = 0;
    var campo = num;
    if (er.test(campo.value)) {
        campo.value = "";
    }
}
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
                data: { id: id }
            }).then(() => {
                window.location.reload();
            });
        };
        $scope.Atualizar = (id) => {
            $http({
                method:"POST",
                url: "/ClientePF/Atualizar",
                data: { id: id }
            }).then((item) => {
                $scope.listaFormulario = [item.data];
            });
        };
        $scope.AlterarDados = (dados) => {
            $http({
                method: "POST",
                url: "/ClientePF/AlterarDados",
                data: dados
            }).then(() => {
                window.location.reload();
            });
        };
});