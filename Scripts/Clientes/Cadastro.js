function somenteNumeros(num) {
    var er = /[^0-9.]/;
    er.lastIndex = 0;
    var campo = num;
    if (er.test(campo.value)) {
        campo.value = "";
    }
}
let app = angular.module("ClienteApp", []);
app.controller("ClienteController", ($scope, $http) => {
    $scope.lista = [{ "Nome": "" }];
    $scope.EnviaDados = (dados) => {
        $http({
            method: "POST",
            url: "/ClientePF/Adicionar",
            data: dados
        }).then((status) => {
            alert(status.data);
            window.location.reload();
      });
    };
    $scope.Valida = (dados) => {
        let ultimoCEP = "";
        if (dados.toString().length = 8 && dados !== ultimoCEP) {
            ultimoCEP = dados;
            $http({
                method:'get',
                url: "http://api.postmon.com.br/v1/cep/" + dados,
                crossDomain: true,
                contentType: "application/json",
                data: {}
            }).then((dados) => {
                $scope.dados.cidade = dados.data.cidade;
                $scope.dados.estado = dados.data.estado;
                $scope.dados.logradouro = dados.data.logradouro;
                $scope.dados.bairro = dados.data.bairro;
                });
        }
    };
});