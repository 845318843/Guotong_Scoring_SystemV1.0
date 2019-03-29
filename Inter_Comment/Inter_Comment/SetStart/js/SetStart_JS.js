/// <reference path="../../../Set2Service.asmx" />
/// <reference path="../../../ScanService.asmx" />
/// <reference path="../../ScanService.asmx" />
/// <reference path="../../Set2Service.asmx" />

var AddItem = false;
var AddValue = false;
var AlterItem = false;
var AlterValue = false;

//加载项目标题
function loaditems() {
    //alert("开始加载");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../ScanService.asmx/getlist",
        data: '{}',
        dataType: "json",
        async: false,
        success: function (result) {
            document.getElementById('start_select').innerHTML += result.d;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}


//添加时内容是否合法
//function additems_legal() {
//    var theme = $("#add_theme").val();
//    var first = $("#add_first").val();
//    var second = $("#add_second").val();
//    var third = $("#add_third").val();
//    var forth = $("#add_forth").val();
//    var fifth = $("#add_fifth").val();
//    if (theme != "" && first != "" && second != "" && third != "" && forth != "" && fifth != "") {
//        AddItem = true;
//    }
//    else {
//        AddItem = false;
//        alert("项目内容不能为空");
//    }


//}


//添加时最大分值是否合法
//function addvalue_legal() {

//    var first = Number($("#add_first_value").val());
//    var second = Number($("#add_second_value").val());
//    var third = Number($("#add_third_value").val());
//    var forth = Number($("#add_forth_value").val());
//    var fifth = Number($("#add_fifth_value").val());
//    if (isInteger(first) && isInteger(second) && isInteger(third) && isInteger(forth) && isInteger(fifth)) {
//        AddValue = true;
//    }
//    else {
//        AddValue = false;
//        alert("数组输入不合法");
//    }
//}


//修改时内容是否合法
//function modifyitem_legal() {
//    var theme = $("#alter_theme").val();
//    var first = $("#alter_first").val();
//    var second = $("#alter_second").val();
//    var third = $("#alter_third").val();
//    var forth = $("#alter_forth").val();
//    var fifth = $("#alter_fifth").val();
//    if (theme != "" && first != "" && second != "" && third != "" && forth != "" && fifth != "") {
//        AlterItem = true;
//    }
//    else {
//        AlterItem = false;
//        alert("项目内容不能为空");
//    }
//}


//修改时最大分值是否合法
//function modifyvalue_legal() {
//    //alert("jinrupanduan");
//    var first = Number($("#alter_first_value").val());
//    var second = Number($("#alter_second_value").val());
//    var third = Number($("#alter_third_value").val());
//    var forth = Number($("#alter_forth_value").val());
//    var fifth = Number($("#alter_fifth_value").val());
//    if (isInteger(first) && isInteger(second) && isInteger(third) && isInteger(forth) && isInteger(fifth)) {
//        AlterValue = true;
//    }
//    else {
//        AlterValue = false;
//        alert("数组输入不合法");
//    }
//}



//添加项目组和相应最大值
//function add() {
//    additems_legal();
//    addvalue_legal();
//    if (AddItem && AddValue) {
//        //项目名称
//        var theme = $("#add_theme").val();
//        var first = $("#add_first").val();
//        var second = $("#add_second").val();
//        var third = $("#add_third").val();
//        var forth = $("#add_forth").val();
//        var fifth = $("#add_fifth").val();
//        //分数
//        var first_value = $("#add_first_value").val();
//        var second_value = $("#add_second_value").val();
//        var third_value = $("#add_third_value").val();
//        var forth_value = $("#add_forth_value").val();
//        var fifth_value = $("#add_fifth_value").val();

//        var maxid = 0;
//        //获取最大ID
//        $.ajax({
//            type: "post",
//            contentType: "application/json",
//            url: "../../../Set2Service.asmx/GetMaxID",
//            data: '{}',
//            dataType: "json",
//            async: false,
//            success: function (result) {
//                maxid = result.d;
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(XMLHttpRequest.status);
//                alert(XMLHttpRequest.readyState);
//                alert(textStatus);
//            }
//        })
//        //添加项目
//        $.ajax({
//            type: "post",
//            contentType: "application/json",
//            url: "../../../Set2Service.asmx/addItem",
//            data: '{"id":' + maxid + ',"theme":"' + theme + '","first":"' + first + '","second":"' + second + '","third":"' + third + '","forth":"' + forth + '","fifth":"' + fifth + '"}',
//            dataType: "json",
//            async: false,
//            success: function (result) {
//                if (result.d) {
//                    alert("项目组添加成功");
//                }
//                else {
//                    alert("项目组添加失败");
//                }
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(XMLHttpRequest.status);
//                alert(XMLHttpRequest.readyState);
//                alert(textStatus);
//            }
//        })
//        //添加分值
//        $.ajax({
//            type: "post",
//            contentType: "application/json",
//            url: "../../../Set2Service.asmx/addValues",
//            data: '{"id":' + maxid + ',"first":' + first_value + ',"second":' + second_value + ',"third":' + third_value + ',"forth":' + forth_value + ',"fifth":' + fifth_value + '}',
//            dataType: "json",
//            async: false,
//            success: function (result) {
//                if (result.d) {
//                    alert("添加最大值成功");
//                }
//                else {
//                    alert("添加最大值失败");
//                }
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(XMLHttpRequest.status);
//                alert(XMLHttpRequest.readyState);
//                alert(textStatus);
//            }
//        })
//    }

//}


////修改项目和相应最大值
//function modify() {
//    modifyitem_legal();
//    modifyvalue_legal();
//    if (AlterItem && AlterValue) {
//        var theme = $("#alter_theme").val();
//        var first = $("#alter_first").val();
//        var second = $("#alter_second").val();
//        var third = $("#alter_third").val();
//        var forth = $("#alter_forth").val();
//        var fifth = $("#alter_fifth").val();


//        var first_value = $("#alter_first_value").val();
//        var second_value = $("#alter_second_value").val();
//        var third_value = $("#alter_third_value").val();
//        var forth_value = $("#alter_forth_value").val();
//        var fifth_value = $("#alter_fifth_value").val();

//        var _value = 99999;
//        var myselect = document.getElementById('alter_select');
//        var index = myselect.selectedIndex;
//        _value = myselect.options[index].value;

//        $.ajax({
//            type: "post",
//            contentType: "application/json",
//            url: "../../../Set2Service.asmx/AlterItem",
//            data: '{"id":' + _value + ',"theme":"' + theme + '","first":"' + first + '","second":"' + second + '","third":"' + third + '","forth":"' + forth + '","fifth":"' + fifth + '"}',
//            dataType: "json",
//            async: false,
//            success: function (result) {
//                if (result.d) {
//                    alert("项目内容修改成功");
//                }
//                else {
//                    alert("项目内容修改失败");
//                }
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(XMLHttpRequest.status);
//                alert(XMLHttpRequest.readyState);
//                alert(textStatus);
//            }
//        })


//        $.ajax({
//            type: "post",
//            contentType: "application/json",
//            url: "../../../Set2Service.asmx/AlterValue",
//            data: '{"id":' + _value + ',"first":' + first_value + ',"second":' + second_value + ',"third":' + third_value + ',"forth":' + forth_value + ',"fifth":' + fifth_value + '}',
//            dataType: "json",
//            async: false,
//            success: function (result) {
//                if (result.d) {
//                    alert("项目分值修改成功");
//                }
//                else {
//                    alert("项目分值修改失败");
//                }
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(XMLHttpRequest.status);
//                alert(XMLHttpRequest.readyState);
//                alert(textStatus);
//            }
//        })
//    }
//}


function setStart() {
    var _value = 99999;
    var myselect = document.getElementById('start_select');
    var index = myselect.selectedIndex;
    _value = myselect.options[index].value;
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../Set2Service.asmx/SetStartItem",
    data: '{"id":'+_value+'}',
    dataType: "json",
    async: false,
    success: function (result) {
        if (result.d) {
            alert("设置启动项成功");
        }
        else {
            alert("设置启动项失败");
        }
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}


//判断一个数是否为正数
function isInteger(obj) {
    return typeof obj === 'number' && obj % 1 === 0 && obj >= 0;
}





//设置启动项时下拉框确定事件
function loadsetstart() {
    var _value = 99999;
    var myselect = document.getElementById('start_select');
    var index = myselect.selectedIndex;
    _value = myselect.options[index].value;
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../Set2Service.asmx/GetInfoById",
    data: '{"id":'+_value+'}',
    dataType: "json",
    async: false,
    success: function (result) {
        var obj = eval("(" + result.d + ")");
        
        document.getElementById('set_first').innerHTML = obj.first;
        document.getElementById('set_second').innerHTML = obj.second;
        document.getElementById('set_third').innerHTML = obj.third;
        document.getElementById('set_forth').innerHTML = obj.forth;
        document.getElementById('set_fifth').innerHTML = obj.fifth;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})

$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../Set2Service.asmx/GetScoreById",
    data: '{"id":'+_value+'}',
    dataType: "json",
    async: false,
    success: function (result) {
        var obj = eval("(" + result.d + ")");
        document.getElementById('set_first_value').innerHTML = obj.first;
        document.getElementById('set_second_value').innerHTML = obj.second;
        document.getElementById('set_third_value').innerHTML = obj.third;
        document.getElementById('set_forth_value').innerHTML = obj.forth;
        document.getElementById('set_fifth_value').innerHTML = obj.fifth;
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})

}
