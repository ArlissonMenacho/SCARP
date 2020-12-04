$('#DataVigencia').datepicker({
    changeYear: true,
    yearRange: 'c-100:c+0',
    minDate: new Date(1920, 1 - 1, 1),
    maxDate: new Date(),
    locale: 'pt-br',
    format: 'dd/mm/yyyy',
    footer: false, modal: false
});