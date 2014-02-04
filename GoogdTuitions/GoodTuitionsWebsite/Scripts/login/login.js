$(document).ready(function () {    
});

function Login() {
    var userId = $('#InputUserId').val().trim();
    var password = $('#InputUserPassword').val();
    
    if (!ValidateEmailAddress(userId)|| userId=='') {
        AlertInfo('Please enter valid User ID.');
        $('#InputUserId').focus();
        return;
    }
    if (password=='') {
        AlertInfo('Please enter valid password.');
        $('#InputUserPassword').focus();
        return;
    }
    var login= {
        EmailAddress: userId,
        Password:password
    };
    $('#hLoadingMedium').removeClass("hide");

    $.ajax({    // ajax start
        type: "POST",
        url: GetAPIUrl('Login'),
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(login),
        success: function (result) {
            $('#hLoadingMedium').addClass("hide");
            var responeMessage = result.Message;
            if (responeMessage == 'Success') {
                window.location.href =GetPageUrl('Profile')+ "?UserId="+userId;
            }
            else {
                AlertError('Login fail due to in-valid User ID or Password');
            }
        },
        error: function () {
            $('#hLoadingMedium').addClass("hide");
        }
    }); // ajax end
}