/// <reference path="../../ScanService.asmx" />
/// <reference path="../../CommentService.asmx" />
/// <reference path="../../../ScanService.asmx" />
/// <reference path="../../GetTrendService.asmx" />

//加载列表
var itemid;
var _years = 2018;
var _months = 01;
var times = "";
function loadlist() {
    //alert("开始加载标题组");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanService.asmx/getlist",
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
    //alert("开始加载各项名称");
    var myselect = document.getElementById('items');
    var index = myselect.selectedIndex;
    itemid = myselect.options[index].value;
    //alert(_value);
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanService.asmx/GetItemsById",
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

//加载年份
function loadyears() {
 $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../GetTrendService.asmx/GetYearsListByThemeId",
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

//加载评分记录 按评分人
function loadrecordbyactor() {
   // alert("评分人");
    var actor = $("#actors").val();

    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanService.asmx/GetRecordByIdAndActorName",
        data: '{"id":' + itemid + ',"username":"' + actor + '","time":"'+times+'"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == "") {
                alert("没有找到相关记录");
            }
            else {
                //alert("找到相关记录");
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


//加载评分记录，按被评分人加载
function loadrecordbypassive() {
    //alert("被评分人");
    var actor = $("#actors").val();
    
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanService.asmx/GetRecordByIdAndPassiveName",
        data: '{"id":' + itemid + ',"username":"' + actor + '","time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == "") {
                alert("没有找到相关记录");
            }
            else {
                //alert("找到相关记录");
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
    if ($("#actors").val() == "") {
        alert("请输入姓名哦~");
    }
    else {
        var myselect1 = document.getElementById('years');
        var myindex1 = myselect1.selectedIndex;
        _years = myselect1.options[myindex1].value;
        var myselect2 = document.getElementById('months');
        var myindex2 = myselect2.selectedIndex;
        _months = myselect2.options[myindex2].value;
        times = _years + "-" + _months;
        document.getElementById('table_test').innerHTML = "";
        loaditems();
        var myselect = document.getElementById('actor_or_passive');
        var index = myselect.selectedIndex;
        var selectwho = myselect.options[index].value;
       
        switch (Number(selectwho)) {
            case 1: loadrecordbyactor(); break;
            case 2: loadrecordbypassive(); break;
            default: break;
        }
    }
}
