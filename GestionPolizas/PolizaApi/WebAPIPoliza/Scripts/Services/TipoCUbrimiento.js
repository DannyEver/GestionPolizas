var dataSource;

$(document).ready(function () {


    //if (localStorage.getItem('token') == null || localStorage.getItem('token') == '') {
    //    window.location.replace("/Home");
    //}



    $.ajax({
        type: 'GET',
        url: 'http://localhost:60741/api/TipoCubrimiento',
        success: function (response) {

            dataSource = response
            console.log(response);

            $.each(dataSource, function (key, value) {
                $("#tipoCubrimiento").append("<option value=" + value.idTCubrimiento + ">" + value.nombre + "</option>");
            });

        },
        error: function (response) {

            console.log(response);

            $("#errorMessage").html("Se ha presentado un error " + response);

            setTimeout(function () { $("#errorMessage").html(""); }, 2000);

        }

    });
});