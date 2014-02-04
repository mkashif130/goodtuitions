$('.input-label').on('click', function () {
    $(this).addClass('input-label-blur');
});
$('.input-label').on('focus', function () {
    $(this).addClass('input-label-blur');
});
$('.input-label').on('blur', function () {
    $(this).removeClass('input-label-blur');
});