
function AlertSuccess(msg) {
    $.msgGrowl({ type: 'success', title: 'Success!', text: msg });
}

function AlertError(msg) {
    $.msgGrowl({ type: 'error', title: 'Error!', text: msg });
}

function AlertInfo(msg) {
    $.msgGrowl({ type: 'info', title: 'Information!', text: msg });
}
function AlertAdminError() {
    $.msgGrowl({ type: 'error', title: 'Error!', text: "Error occur, Please try again later, Contact to Administrator or refresh page" });
}