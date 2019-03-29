/// <reference path="../../../ScanService.asmx" />
/// <reference path="../../../GetTrendService.asmx" />

var times;
//加载年份
function loadyears() {
 $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../../GetTrendService.asmx/GetYearsListByThemeId",
        data: '{}',
        dataType: "json",
        async: false,
        success: function (result) {
            document.getElementById('years').innerHTML += result.d;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}

//加载标题列表
function loadthemes() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/getlist",
    data: '{}',
    dataType: "json",
    async: false,
    success: function (result) {
        document.getElementById('themes').innerHTML += result.d;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}

//加载已评论人员
function loadhavecommented(id) {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/GetHaveCommentJoinerByItemId",
    data: '{"id":'+id+',"time":"'+times+'"}',
    dataType: "json",
    async: false,
    success: function (result) {
        document.getElementById('table_test').innerHTML += result.d;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}

//加载未评论人员
function loadnotcomment(id) {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/GetNotCommentJoinerByItemId",
    data: '{"id":' + id + ',"time":"' +times+ '"}',
    dataType: "json",
    async: false,
    success: function (result) {
        document.getElementById('table_test').innerHTML += result.d;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}

//按钮点击事件
function loadstatus() {
    document.getElementById('table_test').innerHTML = "";
    var myselect = document.getElementById('themes');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;


    var myyear = document.getElementById('years');
    var yearindex = myyear.selectedIndex;
    //alert(myyear.options[yearindex].value);
    var _years = myyear.options[yearindex].value;
    
    var mymonth = document.getElementById('months');
    var monthindex = mymonth.selectedIndex;
    var _months = mymonth.options[monthindex].value;
    times = _years + "-" + _months;

    loadhavecommented(_value);
    loadnotcomment(_value);

}