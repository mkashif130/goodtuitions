$(document).ready(function () {

});

function VerifyToken() {
    var token = GetQueryStringValue("Token");
    var password = $('#InputPassword').val();
    var confirmPassword = $('#InputConfirmPassword').val();
    if (password == '') {
        AlertInfo('Please enter your password.');
        $('#InputPassword').focus();
        return;
    }
    if (password.length < 6) {
        AlertInfo('Password must be greater then or equal to six digits.');
        $('#InputPassword').focus();
        return;
    }

    if (password!=confirmPassword) {
        AlertInfo('Password Miss-match');
        $('#InputPassword').focus();
        return;
    }
    var passwordReset = {
        Token: token,
        Password:password
    };
    $('#hLoadingMedium').removeClass('hide');
    $.ajax({    // ajax start
        type: "POST",
        url: GetAPIUrl('GetTokenVerify'),
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(passwordReset),
        success: function (data, status, xhr) {
            $('#hLoadingMedium').addClass('hide');
            var response = xhr.statusText;
            if (response != null && response == 'Created') {
                AlertSuccess("Your password reset successfully, Now you can login with your new reset password");
            }
            else {
                AlertError(response);
            }
        },
        error: function () {
            $('#hLoadingMedium').addClass('hide');
        }
    }); // ajax end
    
}