/// <reference path="../../../../SetService.asmx" />
function load() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../../SetService.asmx/load",
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
