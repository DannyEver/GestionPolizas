        var dataSource;

        $(document).ready(function () {


            //if (localStorage.getItem('token') == null || localStorage.getItem('token') == '') {
            //    window.location.replace("/Home");
            //}

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
                            { data: "EmailEmpleado", title: "Empleado" }
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


        function GuardarPoliza() {

            var nombre = $('#nombre').val();
            var descripcion = $('#descripcion').val();
            var tipoCubrimiento = $('#tipoCubrimiento').val();
            var inicioVigencia = $('#inicioVigencia').val();
            var periodoCobertura = $('#periodoCobertura').val();
            var precioPoliza = $('#precioPoliza').val();
            var tipoRiesgo = $('#tipoRiesgo').val();

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


        }