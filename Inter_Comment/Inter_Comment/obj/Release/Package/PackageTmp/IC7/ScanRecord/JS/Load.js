/// <reference path="../../CommentService.asmx" />
/// <reference path="../../../ScanService.asmx" />

//加载列表
var actor = "了了了";
var itemid = 9999;
function loadlist() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/getlist",
    data: '{}',
    dataType: "json",
    async: false,
    success: function (result) {
        document.getElementById('items').innerHTML += result.d;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}


//加载各项名称
function loaditems() {
    actor = $("#actors").val();
    var myselect=document.getElementById('items');
    var index = myselect.selectedIndex;
    itemid = myselect.options[index].value;
    //alert(_value);
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/GetItemsById",
    data: '{"id":' + itemid + '}',
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


//加载评分记录
function loadrecord() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../ScanService.asmx/GetRecordByIdAndName",
    data: '{"id":' + itemid + ',"username":"' + actor + '"}',
    dataType: "json",
    async: false,
    success: function (result) {
        if (result.d == "") {
            alert("没有找到相关记录");
        }
        else {
            document.getElementById('table_test').innerHTML += result.d;
        }
        
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}

//确定按钮
function sure() {
    
    loaditems();
    loadrecord();
}
