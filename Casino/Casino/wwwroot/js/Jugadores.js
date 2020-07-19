//Funcion para abrir la modal de los jugadores
//@author: Anderson Benavides
//Fecha: 2020/19/07
function AbrirModalJugadores() {
    LimpiarCampos();
    $("#agregarTipoIdentificacion").removeAttr("readonly");
    $("#agregarNumeroIdentificacion").removeAttr("readonly");
    $("#agregarDineroDisponible").attr("readonly", "readonly");
    $("#agregarJugador").modal();
    $("#operacion").val(1);
}

//Funcion para almacenar la información del jugador
//@author: Anderson Benavides
//Fecha: 2020/19/07
function GuardarJugador(){
    //Validar obligatorios
    var tipoId = $("#agregarTipoIdentificacion").val();
    var numId = $("#agregarNumeroIdentificacion").val();
    var nombre = $("#agregarNombreCompleto").val();
    var edad = $("#agregarEdad").val();
    var sexo = $("#agregarSexo").val();
    var disponible = $("#agregarDineroDisponible").val();
    if (tipoId == '' || numId == '0' || nombre == '' || edad == '' || sexo == '0' || disponible == '') {
        alert("Por favor ingresar todos los campos obligatorios.");
    } else {
        var model = {
            TipoIdentificacionJugador: tipoId,
            IdentificacionJugador: numId,
            NombreJugador: nombre,
            EdadJugador: edad,
            SexoJugador: sexo,
            DisponibleJugador: disponible
        };

        var operacion = $("#operacion").val();
        //1. Agregar
        //2. Editar
        if (operacion == 1) {
            $.ajax({
                type: "POST",
                url: '/Home/AlmacenarJugador',
                data: model,
                dataType: 'json',
                success: function (result) {
                    $("#agregarJugador").modal('hide');
                    location.reload();
                },
                error: function (result) {
                    $("#agregarJugador").modal('hide');
                    location.reload();
                },
            });
        } else {
            $.ajax({
                type: "POST",
                url: '/Home/EditarJugador',
                data: model,
                dataType: 'json',
                success: function (result) {
                    $("#agregarJugador").modal('hide');
                    location.reload();
                },
                error: function (result) {
                    $("#agregarJugador").modal('hide');
                    location.reload();
                },
            });
        }        
    }
}

//Funcion para limpiar los campos de la modal
//@author: Anderson Benavides
//Fecha: 2020/19/07
function LimpiarCampos() {
    $("#agregarTipoIdentificacion").val('0');
    $("#agregarNumeroIdentificacion").val('');
    $("#agregarNombreCompleto").val('');
    $("#agregarEdad").val('');
    $("#agregarSexo").val('0');
    $("#agregarDineroDisponible").val('15000');
}

//Funcion para Editar un jugador
//@author: Anderson Benavides
//Fecha: 2020/19/07
function EditarJugador(tipoId, numId) {
    if (tipoId == '' || numId == '0') {
        alert("Por favor selecciones un jugador con identificación.");
    } else {
        var model = {
            TipoIdentificacionJugador: tipoId,
            IdentificacionJugador: numId
        };

        $.ajax({
            type: "POST",
            url: '/Home/ConsultarJugador',
            data: model,
            dataType: 'json',
            success: function (result) {
                LimpiarCampos();
                $("#agregarTipoIdentificacion").attr("readonly", "readonly");
                $("#agregarNumeroIdentificacion").attr("readonly", "readonly");
                $("#agregarDineroDisponible").removeAttr("readonly");
                $("#agregarJugador").modal();
                $("#operacion").val(2);

                //Precargar campos
                $("#agregarTipoIdentificacion").val(result.tipoIdentificacion);
                $("#agregarNumeroIdentificacion").val(result.identificacion);
                $("#agregarNombreCompleto").val(result.nombre);
                $("#agregarEdad").val(result.edad);
                $("#agregarSexo").val(result.sexo);
                $("#agregarDineroDisponible").val(result.disponible);
            },
            error: function (result) {
                $("#agregarJugador").modal();
            },
        });
    }
}

//Funcion para Eliminar un jugador
//@author: Anderson Benavides
//Fecha: 2020/19/07
function EliminarJugador(tipoId, numId) {
    if (tipoId == '' || numId == '0') {
        alert("Por favor selecciones un jugador con identificación.");
    } else {
        $("#eliminarJugador").modal();
        $("#tipoIdeEliminar").val('');
        $("#ideEliminar").val('');
        $("#tipoIdeEliminar").val(tipoId);
        $("#ideEliminar").val(numId);
    }
}

//Funcion para Confirmar Eliminar un jugador
//@author: Anderson Benavides
//Fecha: 2020/19/07
function ConfirmarEliminarJugador() {
    var model = {
        TipoIdentificacionJugador: $("#tipoIdeEliminar").val(),
        IdentificacionJugador: $("#ideEliminar").val()
    };
    $.ajax({
        type: "POST",
        url: '/Home/EliminarJugador',
        data: model,
        dataType: 'json',
        success: function (result) {
            $("#eliminarJugador").modal('hide');
            location.reload();
        },
        error: function (result) {
            $("#eliminarJugador").modal('hide');
            location.reload();
        },
    });
}