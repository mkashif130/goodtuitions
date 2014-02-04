$(document).ready(function () { // Document ready body start

}); // Document ready body end

function CheckTermsAndConditions() {
    if ($('#chkTermsAndConditions').is(':checked')) {
        $('#btnRegister').attr('disabled', false);
        return;
    }
    $('#btnRegister').attr('disabled', true);
}

function Signup() {

    // Variables declaration
    var firstName = $('#InputFirstName').val().trim();
    var lastName = $('#InputLastName').val().trim();
    var userName = $('#InputUserName').val().trim();
    var email = $('#InputEmail').val().trim();
    var password = $('#InputPassword').val().trim();
    var confirmPassword = $('#InputConfirmPassword').val().trim();

    //  Validations

    if (firstName == '') {
        AlertInfo('Please enter your first name.');
        $('#InputFirstName').focus();
        return;
    }

    if (lastName == '') {
        AlertInfo('Please enter your last name.');
        $('#InputLastName').focus();
        return;
    }

    if (userName == '') {
        AlertInfo('Please enter your user name.');
        $('#InputUserName').focus();
        return;
    }

    if (email == '') {
        AlertInfo('Please enter your email address.');
        $('#InputEmail').focus();
        return;
    }

    if (!ValidateEmailAddress(email)) {
        AlertInfo('Please enter valid E-mail eddress.');
        $('#InputEmail').focus();
        return;
    }

    if (password.length < 6) {
        AlertInfo('Password must be greater then or equal to six digits.');
        $('#InputPassword').focus();
        return;
    }

    if (password == '') {
        AlertInfo('Please enter your password.');
        $('#InputPassword').focus();
        return;
    }

    if (password != confirmPassword) {
        AlertInfo('Password did not match.');
        $('#InputConfirmPassword').focus();
        return;
    }

    // Entity creation
    var signup = {
        FirstName: firstName,
        LastName: lastName,
        UserName: userName,
        EmailAddress: email,
        Password: password
    };
    $('#hLoading').removeClass("hide");

    $.ajax({    // ajax start
        type: "POST",
        url: GetAPIUrl('Signup'),
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(signup),
        success: function (result) {
            $('#hLoading').addClass("hide");
            alert("Success: " + result.status + " : " + result.statusText);
            if (result.Message == 'Created') { // 200 code for successfully creation
                // redirect to success page
                window.location.href = GetPageUrl('Profile')+"?UserId=" + email;
            }
            else {
                //redirect to error page
                window.location.href = GetPageUrl('Error')+"?ErrorCode="+result.Message+"&ErrorMessage=Registration_Fail";
            }
        },
        error: function () {
            $('#hLoading').addClass("hide");
        }
    }); // ajax end

}
