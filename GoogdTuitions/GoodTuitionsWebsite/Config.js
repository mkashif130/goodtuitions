var webHostUrl = 'http://localhost:49942/';
var apiHostUrl = 'http://localhost:55213/';

var pageRoot = 'WebPages/';
var apiRoot = 'API/';
var defaultPage = '/Default.aspx';


var PageUrl = {
    Default: webHostUrl + pageRoot + 'Home' + defaultPage,
    Profile: webHostUrl + pageRoot + 'Profile' + defaultPage,
    Error: webHostUrl + pageRoot + 'Error' + defaultPage
};

var APIUrl = {
    Login: apiHostUrl + apiRoot + 'Auth/Auth/GetLogin/',
    Signup: apiHostUrl + apiRoot + 'User/Signup/AddNewUser/'

};
function GetPageUrl(pageName) {
    if (pageName == 'Profile') {
        return PageUrl.Profile;
    }
    else if (pageName=='Error') {
        return PageUrl.Error;
    }
    return PageUrl.Default;
}

function GetAPIUrl(apiName) {
    if (apiName == 'Login') {
        return APIUrl.Login;
    }
    else if (apiName=='Signup') {
        return APIUrl.Signup;
    }
    return null;
}