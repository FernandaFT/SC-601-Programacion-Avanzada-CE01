$(function () {

    $("#FormMatricula").validate({
        rules: {
            Identificacion: {
                required: true
            },
            Monto: {
                required: true,
                number: true,
                min: 0.01
            },
            TipoCurso: {
                required: true
            }
        },
        messages: {
            Identificacion: {
                required: "Campo requerido"
            },
            Monto: {
                required: "Campo requerido",
                number: "Debe ser numérico",
                min: "Debe ser mayor a 0"
            },
            TipoCurso: {
                required: "Campo requerido"
            }
        },
        errorElement: "span",
        errorClass: "text-light",
        highlight: function (element) {
            $(element).addClass("is-invalid");
        },
        unhighlight: function (element) {
            $(element).removeClass("is-invalid");
        }
    });

});