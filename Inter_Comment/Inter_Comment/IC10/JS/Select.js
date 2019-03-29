/// <reference path="../../../../SetService.asmx" />
function load1() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../DeleteService.asmx/GetAllStaff_Delete",
    data: '{}',
    dataType: "json",
    async: false,
    success: function (result) {
        //alert(result.d);
        document.getElementById("table_test").innerHTML += result.d;
        },
    error: function (XMLHttpRequest,textStatus,errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
}
})
}

function load2() {
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../DeleteService.asmx/GetAllAdmin_Delete",
        data: '{}',
        dataType: "json",
        async: false,
        success: function (result) {
            //alert(result.d);
            document.getElementById("table_test").innerHTML += result.d;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}
