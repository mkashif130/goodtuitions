<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoodTuitionsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Theme/js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="http://connect.facebook.net/en_US/all.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="fb-root">
        <input type="button" value="Signup" onclick="facebookLogin()"/>
    </div>
<iframe src="http://www.facebook.com/plugins/registration.php?
             client_id=1436088256622238&
             redirect_uri=http%3A%2F%2Fdevelopers.facebook.com%2Ftools%2Fecho%2F&
             fields=name,birthday,gender,location,email"
        scrolling="auto"
        frameborder="no"
        style="border:none"
        allowTransparency="true"
        width="100%"
        height="310px">
</iframe>
    </form>
</body>
    <script type="text/javascript">
        FB.init({
            appId: '1436088256622238',
            status: true, // check login status
            cookie: true, // enable cookies to allow the server to access the session
            xfbml: true, // parse XFBML
            channelUrl: 'http://www.xyz.com/channel.html', // channel.html file
            oauth: true // enable OAuth 2.0
        });
    </script>
<%-- ReSharper disable DuplicatingLocalDeclaration --%>
    <script type="text/javascript">
        function facebookLogin() {
            window.FB.login(function (response) {
                if (response.authResponse) {
                    window.FB.api('/me', function (response) {
                        alert(response.first_name + response.last_name+response.email + response.id);
                        jQuery('#txtFirstName').val(response.first_name);
                        jQuery('#txtLastName').val(response.last_name);
                        jQuery('#txtEmail').val(response.email);
                        jQuery('#hdfUID').val(response.id);
                        //                        FB.logout(function (response) {
                        //                        });
                    });
                } else {
                    jQuery('#txtFirstName').val('');
                    jQuery('#txtLastName').val('');
                    jQuery('#txtEmail').val('');
                    jQuery('#hdfUID').val('');
                }
            }, { scope: 'email' });
            return false;
        }
    </script>
<%-- ReSharper restore DuplicatingLocalDeclaration --%>
</html>
