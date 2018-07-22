        var dataSource;

        $(document).ready(function () {


            if (localStorage.getItem('token') == null || localStorage.getItem('token') == '') {
                window.location.replace("/Home");
            }

            $.ajax({
                type: 'GET',
                url: 'http://localhost:60741/api/Poliza',
                success: function (response) {

                    dataSource = response
                    console.log(response);

                    $('#polizasGrid').DataTable({
                        data: dataSource,
                        columns: [
                            { data: "idPoliza", title: "Id Poliza" },
                            { data: "nombre", title: "Nombre" },
                            { data: "descripcion", title: "Descripcion" },
                            { data: "TipoCubrimiento", title: "TipoCubrimiento" },
                            { data: "inicioVigencia", title: "Inicio Vigencia" },
                            { data: "periodoCobertura", title: "Periodo Cobertura" },
                            { data: "precio", title: "Precio" },
                            { data: "TipoRiesgo", title: "Tipo Riesgo" },
                            { data: "porcentajeCubrimiento", title: "Porcentaje cubrimiento" }
                        ]
                    });
                },
                error: function (response) {

                    console.log(response);

                    $("#errorMessage").html("Se ha presentado un error " + response);

                    setTimeout(function () { $("#errorMessage").html(""); }, 2000);

                }

            });
        });

$('.form-control input-number').on('input', function () {
    this.value = this.value.replace(/[^0-9]/g, '');
        });


function AbrirCrear() {
    window.location.replace("/Polizas/CrearPoliza");
}


        function GuardarPoliza() {

            var nombre = $('#nombre').val();
            var descripcion = $('#descripcion').val();
            var tipoCubrimiento = $("#tipoCubrimiento option:selected").val();
            var inicioVigencia = $('#inicioVigencia').val();
            var periodoCobertura = $('#periodoCobertura').val();
            var precioPoliza = $('#precioPoliza').val(); 
            var tipoRiesgo = $("#tipoRiesgo option:selected").val();
            var porcentaje = $('#porcentajeCobertura').val();

            if (nombre == "") {
                $("#errorMessage").html("Por favor ingrese nombre poliza " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#nombre').focus();
            }

            if (inicioVigencia == "") {
                $("#errorMessage").html("Por favor ingrese inicio vigencia " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#inicioVigencia').focus();
            }

            if (precioPoliza == "") {
                $("#errorMessage").html("Por favor ingrese precio poliza " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#precioPoliza').focus();
            }

            if (periodoCobertura == "") {
                $("#errorMessage").html("Por favor ingrese periodo de cobertura vàlido " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#periodoCobertura').focus();
            }  

            if (porcentaje == "") {
                $("#errorMessage").html("Por favor ingrese porcentaje de cobertura vàlido " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#porcentajeCobertura').focus();
            }

            if ($("#tipoRiesgo option:selected").val() == 0) {
                $("#errorMessage").html("Por favor seleccione un tipo de riesgo " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#tipoRiesgo').focus();
            }

            if($("#tipoCubrimiento option:selected").val() == 0) {
                $("#errorMessage").html("Por favor seleccione un tipo de cubrimiento " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#tipoCubrimiento').focus();
            }

            if ((tipoRiesgo == 'Alta') && (porcentaje > 50)){
                $("#errorMessage").html("Porcentaje de cobertura no debe ser mayor al 50% cuando el riesgo es 'Alta' " + response);

                setTimeout(function () { $("#errorMessage").html(""); }, 2000);
                $('#porcentajeCobertura').focus();
            }


            var poliza = {
                nombre: nombre,
                descripcion: descripcion,
                idTipoCubrimiento: tipoCubrimiento,
                inicioVigencia: inicioVigencia,
                periodoCobertura: periodoCobertura,
                precio: precioPoliza,
                idTipoRiesgo: tipoRiesgo,
                porcentajeCubrimiento: porcentaje
            };


            $.ajax({
                type: 'POST',
                url: 'http://localhost:60741/api/Poliza',
                data: JSON.stringify(poliza),
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (response) {

                    dataSource = response
                    console.log(response);
                },
                error: function (response) {

                    console.log(response);

                    $("#errorMessage").html("Se ha presentado un error " + response);

                    setTimeout(function () { $("#errorMessage").html(""); }, 2000);

                }
            });
        }