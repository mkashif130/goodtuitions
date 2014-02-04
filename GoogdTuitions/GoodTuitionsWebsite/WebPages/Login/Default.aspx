<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Title="Good Tuitions | Login" Inherits="GoodTuitionsWebsite.Login.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Good Tuitions | Login</title>

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
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="center-block logig-form center">
                <div class="panel panel-default">
                    <div class="panel-heading">Let's get in</div>
                    <div class="panel-body">
                        <form role="form">
                            <div class="form-group">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                    <input type="text" id="InputUserId" class="form-control" placeholder="User ID">
                                </div>
                                <br>
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                    <input type="password" id="InputUserPassword" class="form-control" placeholder="Password">
                                </div>
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox">
                                        Remember me
                                    </label>
                                </div>
                                <button ID="btnLogin" type="button" onclick="Login();" class="btn btn-primary pull-right" >Login</button>
                                <a href="#" class="social-icon soc-twitter animated fadeInDown animation-delay-2"><i class="fa fa-twitter"></i></a>
                                <a href="#" class="social-icon soc-google-plus animated fadeInDown animation-delay-3"><i class="fa fa-google-plus"></i></a>
                                <a href="#" class="social-icon soc-facebook animated fadeInDown animation-delay-4"><i class="fa fa-facebook"></i></a>
                                <br/>
                                <img src="../../Images/h-loading-medium.GIF" id="hLoadingMedium" class="pull-right hide"/>
                                <hr>
                                <!-- Button trigger modal -->
                                <button class="btn btn-success pull-right" data-toggle="modal" data-target="#signUp">
                                    Create Account
                                </button>

                                <!-- Modal Signup -->
                                <div class="modal fade" id="signUp" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                    <div class="modal-dialog center">
                                        <div class="panel panel-primary animated fadeInDown">
                                            <div class="panel-heading">
                                                Signup
                                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            </div>
                                            <div class="panel-body">
                                                <form role="form">
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                                                <input type="text" class="form-control" id="InputFirstName" placeholder="First Name">
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                                                <input type="text" class="form-control" id="InputLastName" placeholder="Last Name">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <br />
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                                                <input type="text" class="form-control" id="InputUserName" placeholder="User Name">
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-envelope"></i></span>
                                                                <input type="email" class="form-control" id="InputEmail" placeholder="Email Address">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <br />
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                                                <input type="password" class="form-control" id="InputPassword" placeholder="Password">
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                                                <input type="password" class="form-control" id="InputConfirmPassword" placeholder="Confirm Password">
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-md-12">
                                                            <label class="checkbox-inline col-md-12 top-bar">
                                                                <input type="checkbox" id="chkTermsAndConditions" value="option1" onchange="CheckTermsAndConditions();">
                                                                I agree with <a href="#">Terms and Conditions</a>.
                                                            </label>
                                                        </div>
                                                    </div>
                                                    <div class="signup-modal-footer">
                                                        <img src="../../Images/h-loading.gif" id="hLoading" class="hide" />
                                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
                                                        <button type="button" id="btnRegister" class="btn btn-primary" onclick="Signup();" disabled>Register</button>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                        <!-- modal-content -->
                                    </div>
                                    <!-- modal-dialog -->
                                </div>
                                <!-- modal -->
                                <a href="#" class="btn btn-warning">Password Recovery</a>
                                <div class="clearfix"></div>
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
    <script src="../../Theme/js/bootstrap.min.js"></script>
    <script src="../../Theme/plugins/GrowlMessages/Js/msgGrowl.min.js"></script>
    <script src="../../Theme/custom-js/glow-common.js"></script>
    <script src="../../Theme/custom-js/application.js"></script>
    <script src="../../Scripts/login/login.js"></script>
    <script src="../../Scripts/signup/signup.js"></script>
    <script type="text/javascript">
        SyntaxHighlighter.all();
    </script>
</body>
</html>
