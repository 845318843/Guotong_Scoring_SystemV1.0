/// <reference path="../../ScanGradeService.asmx" />
/// <reference path="../../ScanGradeService.asmx" />
/// <reference path="../../GetTrendService.asmx" />
//加载列表
var successful = false;
function loadlist() {
    //alert("加载列表");
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


//加载各项名称
function loaditems() {
    //alert("加载项目名称");
    document.getElementById('table_test').innerHTML = "";
    var myselect = document.getElementById('themes');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    //alert(_value);
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../../ScanService.asmx/Score_GetItemsById",
        data: '{"id":' + _value + '}',
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
    //alert("加载年份");
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



//加载成绩列表
function loadgrade() {
    var myselect = document.getElementById('years');
    var myindex1 = myselect.selectedIndex;
    var _years = myselect.options[myindex1].value;
    var myselect2 = document.getElementById('months');
    var myindex2 = myselect2.selectedIndex;
    var _months = myselect2.options[myindex2].value;
    var times = _years + "-" + _months;
    var mytheme = document.getElementById('themes');
    var myindex3 = mytheme.selectedIndex;
    var itemsid = mytheme.options[myindex3].value;
    //alert("移动成绩");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveGradeToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动第一名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveFirstOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动第二名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveSecondOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动第三名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveThirdOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动第四名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveForthOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动第五名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveFifthOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    //alert("移动总名次");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanGradeService.asmx/MoveSumOrderToTemp",
        data: '{"id":' + itemsid + ',"time":"' + times + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == true) {
                successful = true;
            }
            else {
                successful = false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            successful = false;
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    //alert(successful);
    if (successful == true) {
        $.ajax({
            type: "post",
            contentType: "application/json",
            url: "../../ScanGradeService.asmx/GetGradeFromTemp",
            data: '{}',
            dataType: "json",
            async: false,
            success: function (result) {
                document.getElementById('table_test').innerHTML += result.d;
                
                
               
                //alert("开始生成excel");
                //在表清空之前导出数据到Excel中
                $.ajax({
                    type: "post",
                    contentType: "application/json",
                    url: "../../ScanGradeService.asmx/createexcel",
                    data: '{"id":' + itemsid + '}',
                    dataType: "json",
                    async: false,
                    success: function (result) {
                        if (result.d) {
                            alert("成绩表已经导入到Excel表中，请在底部点击下载");
                            $("#download").css("display", "block");
                        }
                        else {
                            alert("数据导出到Excel失败，请联系开发者");
                        }
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(XMLHttpRequest.status);
                        alert(XMLHttpRequest.readyState);
                        alert(textStatus);
                    }
                });
                $.ajax({
                    type: "post",
                    contentType: "application/json",
                    url: "../../ScanGradeService.asmx/ClearTemp",
                    data: '{}',
                    dataType: "json",
                    async: false,
                    success: function (result) {

                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(XMLHttpRequest.status);
                        alert(XMLHttpRequest.readyState);
                        alert(textStatus);
                    }
                });
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
            }
        })
    }
    else {
        alert("数据获取失败");
    }

}


//加载评分记录
//function loadrecord() {
//    $.ajax({
//        type: "post",
//        contentType: "application/json",
//        url: "../../../ScanService.asmx/GetGrade",
//        data: '{"id":' + _value + '}',
//        dataType: "json",
//        async: false,
//        success: function (result) {
//            if (result.d == "") {
//                alert("没有找到相关记录");
//            }
//            else {
//                document.getElementById('table_test').innerHTML += result.d;
//            }

//        },
//        error: function (XMLHttpRequest, textStatus, errorThrown) {
//            alert(XMLHttpRequest.status);
//            alert(XMLHttpRequest.readyState);
//            alert(textStatus);
//        }
//    })
//}

//确定按钮
function sure() {
    //document.getElementById('table_test').innerHTML = "";

    loaditems();
    loadgrade();

}