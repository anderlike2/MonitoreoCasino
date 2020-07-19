//Funcion para abrir la modal de participacion del juego
//@author: Anderson Benavides
//Fecha: 2020/19/07
function AbrirModalParticiparJuego(nombre, disponible, identificacion) {
    LimpiarCampos();
    $("#simuladorNombreCompleto").attr("readonly", "readonly");
    $("#simuladorDineroDisponible").attr("readonly", "readonly");
    $("#simuladorCantidadApostada").attr("readonly", "readonly");
    $("#simuladorNombreCompleto").val(nombre);
    $("#simuladorDineroDisponible").val(disponible);    

    if (disponible > 0 && disponible <= 1000) {
        $("#simuladorOpciones").val(100);
        $("#simuladorOpciones").attr("disabled", true);
        $("#simuladorCantidadApostada").val((disponible * 100) / 100);
        $("#valorApostado").val($("#simuladorCantidadApostada").val());
    } else {
        $("#simuladorOpciones").val(0);
        $("#simuladorOpciones").attr("disabled", false);
    }    
    $("#idSeleccionado").val(identificacion);
    $("#participarJuego").modal();
}

//Funcion para limpiar los campos de la modal
//@author: Anderson Benavides
//Fecha: 2020/19/07
function LimpiarCampos() {
    $("#simuladorNombreCompleto").val('');
    $("#simuladorDineroDisponible").val('');
    $("#simuladorOpciones").val('0');
    $("#simuladorColores").val('0');
    $("#simuladorCantidadApostada").val('');
    $('#colorSeleccionado').css('background-color', 'white');
}

//Funcion para limpiar los campos de la modal
//@author: Anderson Benavides
//Fecha: 2020/19/07
function CambiarColor() {
    var color = $("#simuladorColores").val();
    if (color == 0) {
        $('#colorSeleccionado').css('background-color', 'white');
    } else if (color == 1) {
        $('#colorSeleccionado').css('background-color', 'red');
    } else if (color == 2) {
        $('#colorSeleccionado').css('background-color', 'black');
    } else {
        $('#colorSeleccionado').css('background-color', 'green');
    }
}

//Funcion para Guardar temporalmente la apuesta
//@author: Anderson Benavides
//Fecha: 2020/19/07
function GuardarApuesta() {
    //Validar obligatorios
    var nombre = $("#simuladorNombreCompleto").val();
    var disponible = $("#simuladorDineroDisponible").val();
    var opciones = $("#simuladorOpciones").val();
    var colores = $("#simuladorColores").val();
    if (nombre == '' || disponible == '' || opciones == '0' || colores == '0') {
        alert("Por favor ingresar todos los campos obligatorios.");
    } else {
        $("#participarJuego").modal('hide');
        var htmlConcat = '';
        if (colores == 0) {
            htmlConcat = "";
        } else if (colores == 1) {
            htmlConcat = "<button class='btn btn-danger'><span> $ " + $("#valorApostado").val() + "</span></button>";
        } else if (colores == 2) {
            htmlConcat = "<button class='btn btn-secondary'> $ " + $("#valorApostado").val() + "<span></span></button>";
        } else {
            htmlConcat = "<button class='btn btn-success'> $ " + $("#valorApostado").val() + "<span></span></button>";
        }
        var id = '.table #row_' + $("#idSeleccionado").val() + ' #apuesta_' + $("#idSeleccionado").val();
        $(id).html(htmlConcat);
    }
}

//Funcion para limpiar los campos de la modal
//@author: Anderson Benavides
//Fecha: 2020/19/07
function CalcularCantidad() {
    var opcion = $("#simuladorOpciones").val();
    if (opcion == 0) {
        $("#simuladorCantidadApostada").val('');
    } else {
        var disponible = $("#simuladorDineroDisponible").val();
        $("#simuladorCantidadApostada").val((disponible * opcion) / 100);
    }
    $("#valorApostado").val($("#simuladorCantidadApostada").val());
}