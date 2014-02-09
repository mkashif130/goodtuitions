$(document).ready(function () {
});

function ChangePassword() {
    var currentPassword = $('#InputCurrentPassword').val();
    var newPassword = $('#InputNewPassword').val();
    var confirmNewPassword = $('#InputConfirmNewPassword').val();

    if (currentPassword == '') {
        AlertInfo('Please enter your current password.');
        $('#InputCurrentPassword').focus();
        return;
    }
    if (currentPassword.length < 6) {
        AlertInfo('Password must be greater then or equal to six digits.');
        $('#InputCurrentPassword').focus();
        return;
    }
    if (newPassword == '') {
        AlertInfo('Please enter your current password.');
        $('#InputNewPassword').focus();
        return;
    }
    if (confirmNewPassword == '') {
        AlertInfo('Please confirm your current password.');
        $('#InputConfirmNewPassword').focus();
        return;
    }
    if (newPassword.length < 6) {
        AlertInfo('Password must be greater then or equal to six digits.');
        $('#InputNewPassword').focus();
        return;
    }

    if (newPassword != confirmNewPassword) {
        AlertInfo('Password did not match.');
        $('#InputNewPassword').focus();
        return;
    }

    var changePassword = {
        CurrentPassword: currentPassword,
        NewPassword: newPassword
    };

    $('#hLoading').removeClass("hide");

    $.ajax({    // ajax start
        type: "POST",
        url: GetAPIUrl('ChangePassword'),
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(changePassword),
        success: function (data, status, xhr) {
            $('#hLoading').addClass("hide");
            var response = xhr.statusText;
            if (response != null) {
                if (response == 'OK') { // 200 code for successfully creation
                    // redirect to success page
                    AlertSuccess("Password changed successfully!");
                }
                else {
                    //redirect to error page
                    AlertError(response);
                }
            }
            else {
                AlertError('Uknown Error');
            }
        },
        error: function () {
            $('#hLoading').addClass("hide");
        }
    }); // ajax end
}