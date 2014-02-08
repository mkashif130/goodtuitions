<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoodTuitionsWebsite.WebPages.PasswordReset.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Good Tuitions | Password Reset</title>

    <!-- CSS -->
    <link href="../../Theme/css/bootstrap.min.css" rel="stylesheet" media="screen" />
    <link href="../../Theme/css/font-awesome.min.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/animate.min.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/style.css" rel="stylesheet" media="screen" title="default">
    <link href="../../Theme/plugins/GrowlMessages/css/msgGrowl.css" rel="stylesheet" />
    <link href="../../Theme/custom-css/custom-common.css" rel="stylesheet" />


    <!-- Fav icon -->
    <link rel="shortcut icon" href="../../Theme/custom-images/favicon.ico" type="image/x-icon">
    <link rel="icon" href="../../Theme/custom-images/favicon.ico" type="image/x-icon">
</head>
<body class="body-bg">
    <form id="form1" runat="server">
        <div class="container">
            <div class="center-block logig-form center-signup" id="passwordResetForm">
                <div class="panel panel-default">
                    <div class="panel-heading">Reset Password</div>
                    <div class="panel-body">
                        <form role="form">
                            <div class="form-group">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                    <input type="password" id="InputPassword" class="form-control" placeholder="Password">
                                </div>
                                <br>
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                    <input type="password" id="InputConfirmPassword" class="form-control" placeholder="Confirm Password">
                                </div>
                                <div class="hr"></div>
                                <button id="btnLogin" type="button" onclick="VerifyToken();" class="btn btn-primary pull-right">Reset</button>
                                <a href="#" class="social-icon soc-twitter animated fadeInDown animation-delay-2"><i class="fa fa-twitter"></i></a>
                                <a href="#" class="social-icon soc-google-plus animated fadeInDown animation-delay-3"><i class="fa fa-google-plus"></i></a>
                                <a href="#" class="social-icon soc-facebook animated fadeInDown animation-delay-4"><i class="fa fa-facebook"></i></a>
                                <br />
                                <img src="../../Images/h-loading-medium.GIF" id="hLoadingMedium" class="pull-right hide" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        <!-- container  -->
    </form>
    <!-- Scripts -->
    <script src="../../Theme/js/jquery-1.10.2.min.js"></script>
    <script src="../../Config.js"></script>
    <script src="../../Theme/plugins/BlockUIContents/jquery.blockUI.js"></script>
    <script src="../../Theme/custom-js/block-body-contents.js"></script>
    <script src="../../Scripts/verification/password-reset.js"></script>
    <script src="../../Theme/js/bootstrap.min.js"></script>
    <script src="../../Theme/plugins/GrowlMessages/Js/msgGrowl.min.js"></script>
    <script src="../../Theme/custom-js/glow-common.js"></script>
    <script src="../../Theme/custom-js/application.js"></script>
    <script type="text/javascript">
        SyntaxHighlighter.all();
    </script>
</body>
</html>
