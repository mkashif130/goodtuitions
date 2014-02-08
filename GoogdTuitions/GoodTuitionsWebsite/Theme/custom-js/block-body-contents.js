function BlockUI() {
    $.blockUI({ message: '<h4><img src="../../Images/loading-x-small.GIF" width="25" height="25" class="img-loading-block-ui"/> Just a moment...</h4>' });
}

function UnblockUI() {
    $.unblockUI();
}