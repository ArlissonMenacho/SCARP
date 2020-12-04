$('#DataVigencia').datepicker({
    changeYear: true,
    yearRange: 'c-100:c+0',
    minDate: new Date(1920, 1 - 1, 1),
    maxDate: new Date(),
    locale: 'pt-br',
    format: 'dd/mm/yyyy',
    footer: false, modal: false
});

function BuscarAtas() {
    var numeroAta = $("#numAta").val();
    var anoAta = $("#anoDaAta").val();
    var descAta = $("#descricaoDaAta").val();
    var checkAdesao = $("#checkAdesao").val();
    $.ajax({
        type: "POST",
        url: '/Relatorio/ConsultaAta/',
        data: { codigoAta: numeroAta, anoAta: anoAta, descricaoAta: descAta, adesao: checkAdesao },
        success: function (response) {
            $("#resultadoListaAtas").empty();
            $("#resultadoListaAtas").append(response);
        },
        error: function (response) {
            alert("Erro na consulta, Tente novamente mais tarde ! ");
        }
    });

}