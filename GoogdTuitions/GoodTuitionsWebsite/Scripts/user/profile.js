$(document).ready(function () {
    var userId = GetQueryStringValue('UserId');
    if (userId != '' || userId != null) {
        LoadProfile(userId);
    }
});

function LoadProfile(userId) {
    $('.img-loading').removeClass("hide");
    $.ajax({    // ajax start
        type: "GET",
        url: "http://localhost:55213/API/User/Profile/GetProfile/",
        contentType: 'application/json; charset=utf-8',
        data: { id: userId },
        success: function (result) {
            $('.img-loading').addClass("hide");
            $('#InputFirstName').val(result.FirstName);
            $('#InputLastName').val(result.LastName);
            $('#InputUserName').val(result.UserName);
            $('#InputMemberSince').html(result.RegistrationDateTime);
            $('#InputCellPhoneNumber').val(result.CellNo);
            $('#InputTelephoneNumber').val(result.TelephoneNo);
            $('#InputEmail').val(result.EmailAddress);
            $('#InputAddress').val(result.Address);
            $('#InputCountry').val(result.Country);
            $('#InputProvince').val(result.Province);
            $('#InputCity').val(result.City);
        },
        error: function () {
            $('#hLoading').addClass("hide");
        }
    }); // ajax end
}