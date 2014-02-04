<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/GoodTuition.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoodTuitionsWebsite.WebPages.Profile.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Theme/custom-css/profile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="body-content">
        <header class="wrap-title">
            <div class="container">
                <h1 class="page-title">Profile</h1>

                <ol class="breadcrumb hidden-xs">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Pages</a></li>
                    <li class="active">Profile</li>
                </ol>
            </div>
        </header>
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <section>
                        <img src="../../Theme/img/avatar370.jpg" alt="avatar" class="img-responsive imageborder full-width">
                         <button type="button" class="btn btn-success btn-block">Upload Photo</button>
                    </section>
                </div>
                <div class="col-md-8">
                    <div class="panel panel-primary">
                        <div class="panel-heading"><i class="fa fa-user"></i>User Information</div>
                        <table class="table table-striped profileArea">
                            <tr>
                                <th class="col-md-2">First Name</th>
                                <td>
                                    <input id="InputFirstName" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Last Name</th>
                                <td>
                                    <input id="InputLastName" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">User Name</th>
                                <td>
                                    <input id="InputUserName" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Member Since</th>
                                <td>
                                    <label id="InputMemberSince" class="profile-field" />
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div class="panel panel-primary">
                        <div class="panel-heading"><i class="fa fa-phone"></i>Contact Information</div>
                        <table class="table table-striped profileArea">
                            <tr>
                                <th class="col-md-2">Cell #</th>
                                <td>
                                    <input id="InputCellPhoneNumber" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Telephone #</th>
                                <td>
                                    <input id="InputTelephoneNumber" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Email</th>
                                <td>
                                    <input id="InputEmail" class="input-label profile-field" /></td>
                            </tr>
                        </table>
                    </div>

                    <div class="panel panel-primary">
                        <div class="panel-heading"><i class="fa fa-road"></i>Address Information</div>
                        <table class="table table-striped profileArea">
                            <tr>
                                <th class="col-md-2">Address</th>
                                <td>
                                    <input id="InputAddress" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Country</th>
                                <td>
                                    <input id="InputCountry" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">Province</th>
                                <td>
                                    <input id="InputProvince" class="input-label profile-field" /></td>
                            </tr>
                            <tr>
                                <th class="col-md-2">City</th>
                                <td>
                                    <input id="InputCity" class="input-label profile-field" /></td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="col-md-12">
                    <button class="btn btn-success pull-right">
                        Save Profile
                    </button>
                </div>
            </div>
        </div>
        <!-- container  -->
    </div>

    <script src="../../Theme/js/jquery-1.10.2.min.js"></script>
    <script src="../../Theme/custom-js/control-common.js"></script>
    <script src="../../Theme/custom-js/application.js"></script>
    <script src="../../Scripts/user/profile.js"></script>
</asp:Content>
