var dataSource;

$(document).ready(function () {


    //if (localStorage.getItem('token') == null || localStorage.getItem('token') == '') {
    //    window.location.replace("/Home");
    //}



    $.ajax({
        type: 'GET',
        url: 'http://localhost:60741/api/TipoRiesgo',
        success: function (response) {

            dataSource = response
            console.log(response);

            $.each(dataSource, function (key, value) {
                $("#tipoRiesgo").append("<option value=" + value.idRiesgo + ">" + value.nombre + "</option>");
            });

        },
        error: function (response) {

            console.log(response);

            $("#errorMessage").html("Se ha presentado un error " + response);

            setTimeout(function () { $("#errorMessage").html(""); }, 2000);
        }
    });
});