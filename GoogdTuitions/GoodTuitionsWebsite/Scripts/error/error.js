$(document).ready(function () {
    var errorCode = GetQueryStringValue("ErrorCode");
    var errorMessage = GetQueryStringValue("ErrorMessage");
    if (errorCode.trim()!='') {
        $('.error-code').html(errorCode);
        if (errorMessage.trim() != '') {
            errorMessage = errorMessage.replace('_', ' ');
            $('#error-message').html(errorMessage);
        }
    }
});