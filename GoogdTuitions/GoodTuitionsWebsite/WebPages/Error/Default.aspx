<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoodTuitionsWebsite.WebPages.Error.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head id="Head1" runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Good Tuitions</title>

    <!-- CSS -->
    <link href="../../Theme/css/bootstrap.min.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/font-awesome.min.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/animate.min.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/lightbox.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/syntax/shCore.css" rel="stylesheet" media="screen">
    <link href="../../Theme/css/syntax/shThemeDefault.css" rel="stylesheet" media="screen">


    <link href="../../Theme/css/style.css" rel="stylesheet" media="screen" title="default">
    <link href="../../Theme/css/color-default.css" rel="stylesheet" media="screen" title="default">
    <link href="../../Theme/css/width-full.css" rel="stylesheet" media="screen" title="default">

    <link href="../../Theme/custom-css/custom-common.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src="../../Theme/js/html5shiv.js"></script>
        <script src="../../Theme/js/respond.min.js"></script>
    <![endif]-->

    <!-- Fav icon -->
    <link rel="shortcut icon" href="../../Theme/custom-images/favicon.ico" type="image/x-icon">
    <link rel="icon" href="../../Theme/custom-images/favicon.ico" type="image/x-icon">
</head>
<body>
    <form id="form1" runat="server">
        <!-- Setting Options -->
        <div id="color-switcher" class="animated fadeIn animation-dalay-10">
            <div id="color-switcher-tab">
                <i class="fa fa-gear fa fa-2x"></i>
            </div>
            <div id="color-switcher-content">
                <h3>Color Selector</h3>
                <a href="#" rel="color-default.css" class="color default">default</a>
                <a href="#" rel="color-niceblue.css" class="color niceblue">niceblue</a>
                <a href="#" rel="color-intenseblue.css" class="color intenseblue">intenseblue</a>
                <a href="#" rel="color-otherblue.css" class="color otherblue">otherblue</a>
                <a href="#" rel="color-blue.css" class="color blue">blue</a>
                <a href="#" rel="color-puregreen.css" class="color puregreen">puregreen</a>
                <a href="#" rel="color-grassgreen.css" class="color grassgreen">grassgreen</a>
                <a href="#" rel="color-green.css" class="color green">green</a>
                <a href="#" rel="color-olive.css" class="color olive">olive</a>
                <a href="#" rel="color-gold.css" class="color gold">gold</a>
                <a href="#" rel="color-orange.css" class="color orange">orange</a>
                <a href="#" rel="color-pink.css" class="color pink">pink</a>
                <a href="#" rel="color-fuchsia.css" class="color fuchsia">fuchsia</a>
                <a href="#" rel="color-violet.css" class="color violet">violet</a>
                <a href="#" rel="color-red.css" class="color red">red</a>

                <h3>Container Selector</h3>
                <div class="btn-group">
                    <button href="#" class="option btn btn-sm btn-primary" rel="width-boxed.css">Boxed</button>
                    <button href="#" class="option btn btn-sm btn-primary" rel="width-full.css">Full Width</button>
                </div>
            </div>
        </div>
        <!-- color-switcher -->

        <div class="boxed animated fadeIn animation-delay-5">

            <header id="header" class="hidden-xs">
                <div class="container">
                    <div id="header-title">
                        <h1 class="animated fadeInDown"><a href="#">good <span>Tuitions</span></a></h1>
                        <p class="animated fadeInLeft">lets get in tuition world</p>
                    </div>

                    <div id="social-header" class="hidden-xs">
                        <a href="#" class="social-icon soc-twitter animated fadeInDown animation-delay-1"><i class="fa fa-twitter"></i></a>
                        <a href="#" class="social-icon soc-google-plus animated fadeInDown animation-delay-2"><i class="fa fa-google-plus"></i></a>
                        <a href="#" class="social-icon soc-facebook animated fadeInDown animation-delay-3"><i class="fa fa-facebook"></i></a>
                        <a href="#" class="social-icon soc-instagram animated fadeInDown animation-delay-4"><i class="fa fa-instagram"></i></a>
                        <a href="#" class="social-icon soc-pinterest animated fadeInDown animation-delay-5"><i class="fa fa-pinterest"></i></a>
                        <a href="#" class="social-icon soc-linkedin animated fadeInDown animation-delay-6"><i class="fa fa-linkedin"></i></a>
                        <a href="#" class="social-icon soc-github animated fadeInDown animation-delay-7"><i class="fa fa-github"></i></a>
                    </div>

                    <div id="search-header" class="hidden-xs animated bounceInRight">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                        <!-- /input-group -->
                    </div>
                </div>
                <!-- container -->
            </header>
            <!-- header -->

        </div>
        <div class="body-content">
            <header class="wrap-title">
            <div class="container">
                <h1 class="page-title error-code" >Error 404</h1>

                <ol class="breadcrumb hidden-xs">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Pages</a></li>
                    <li class="active error-code">Error 404</li>
                </ol>
            </div>
        </header>

            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block error-404">
                            <section class="text-center">
                            <h1 class="error-code">Error 404</h1>
                            <h2><span id="error-message">Page not found</span></h2>
                        </section>                          
                        </div>
                    </div>
                </div>
                <!-- row -->
            </div>
            <!-- container -->
        </div>
        <aside id="footer-widgets">
            <div class="container">
                <div class="row">
                    <div class="col-md-4">
                        <h3 class="footer-widget-title">Sitemap</h3>
                        <ul class="list-unstyled three_cols">
                            <li><a href="#">Home</a></li>
                            <li><a href="#">Blog</a></li>
                            <li><a href="#">Portafolio</a></li>
                            <li><a href="#">Works</a></li>
                            <li><a href="#">Gallery</a></li>
                            <li><a href="#">Pricing</a></li>
                            <li><a href="#">About Us</a></li>
                            <li><a href="#">Our Team</a></li>
                            <li><a href="#">Services</a></li>
                            <li><a href="#">FAQ</a></li>
                            <li><a href="#">Login</a></li>
                            <li><a href="#">Cantact</a></li>
                        </ul>
                        <h3 class="footer-widget-title">Subscribe</h3>
                        <p>Lorem ipsum Amet fugiat elit nisi anim mollit in labore ut esse Duis ullamco ad dolor veniam velit lorem ipsum dolor sit amet, consectetur adipisicing..</p>
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Email Adress">
                            <span class="input-group-btn">
                                <button class="btn btn-success" type="button">Subscribe</button>
                            </span>
                        </div>
                        <!-- /input-group -->
                    </div>
                    <div class="col-md-4">
                        <div class="footer-widget">
                            <h3 class="footer-widget-title">Recent Post</h3>
                            <div class="media">
                                <a class="pull-left" href="#">
                                    <img class="media-object" src="../../Theme/img/m2.jpg" width="75" height="75" alt="image"></a>
                                <div class="media-body">
                                    <h4 class="media-heading"><a href="#">Lorem ipsum Duis quis occaecat minim lorem ipsum tempor officia labor</a></h4>
                                    <small>August 18, 2013</small>
                                </div>
                            </div>
                            <div class="media">
                                <a class="pull-left" href="#">
                                    <img class="media-object" src="../../Theme/img/m11.jpg" width="75" height="75" alt="image"></a>
                                <div class="media-body">
                                    <h4 class="media-heading"><a href="#">Lorem ipsum dolor excepteur sunt in lorem ipsum cillum tempor</a></h4>
                                    <small>September 14, 2013</small>
                                </div>
                            </div>
                            <div class="media">
                                <a class="pull-left" href="#">
                                    <img class="media-object" src="../../Theme/img/m4.jpg" width="75" height="75" alt="image"></a>
                                <div class="media-body">
                                    <h4 class="media-heading"><a href="#">Lorem ipsum Dolor cupidatat adipisicing et fugiat</a></h4>
                                    <small>October 9, 2013</small>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="footer-widget">
                            <h3 class="footer-widget-title">Recent Works</h3>
                            <div class="row">
                                <div class="col-lg-6 col-md-6 col-sm-3 col-xs-6">
                                    <a href="#" class="thumbnail">
                                        <img src="../../Theme/img/wf1.jpg" class="img-responsive" alt="Image"></a>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-3 col-xs-6">
                                    <a href="#" class="thumbnail">
                                        <img src="../../Theme/img/wf2.jpg" class="img-responsive" alt="Image"></a>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-3 col-xs-6">
                                    <a href="#" class="thumbnail">
                                        <img src="../../Theme/img/wf3.jpg" class="img-responsive" alt="Image"></a>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-3 col-xs-6">
                                    <a href="#" class="thumbnail">
                                        <img src="../../Theme/img/wf4.jpg" class="img-responsive" alt="Image"></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- row -->
            </div>
            <!-- container -->
        </aside>
        <!-- footer-widgets -->
        <footer id="footer">
            <p>&copy; 2014 <a href="#">Good Tuitions</a>, inc. All rights reserved.</p>
        </footer>
    </form>
    <!-- Scripts -->
    <script src="../../Theme/js/jquery-1.10.2.min.js"></script>
    <script src="../../Theme/custom-js/application.js"></script>
    <script src="../../Scripts/error/error.js"></script>
    <script src="../../Theme/js/jquery.cookie.js"></script>
    <script src="../../Theme/js/bootstrap.min.js"></script>
    <script src="../../Theme/js/jquery.mixitup.min.js"></script>
    <script src="../../Theme/js/lightbox-2.6.min.js"></script>
    <script src="../../Theme/js/holder.js"></script>
    <script src="../../Theme/js/app.js"></script>
    <script src="../../Theme/js/styleswitcher.js"></script>

    <script src="../../Theme/js/syntax/shCore.js"></script>
    <script src="../../Theme/js/syntax/shBrushXml.js"></script>
    <script src="../../Theme/js/syntax/shBrushJScript.js"></script>

    <script type="text/javascript">
        SyntaxHighlighter.all()
    </script>
</body>
</html>
