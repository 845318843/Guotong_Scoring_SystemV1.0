/// <reference path="../../CommentService.asmx" />
//加载项目组
function loaditem() {
    var ID = sessionStorage["ItemsID"];
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../CommentService.asmx/getitems",
        data: '{"ID":' + ID + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            document.getElementById('table_test').innerHTML += result.d;
            //把最大分值加载出来
            loadvalues();
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}

//加载标题
function loadtheme() {
    var ID = sessionStorage["ItemsID"];
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../CommentService.asmx/getthemebyid",
        data: '{"ID":' + ID + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            document.getElementById('theme').innerHTML = result.d;
            //把最大分值加载出来

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}

//加载最大分值
function loadvalues() {
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../CommentService.asmx/GetMaxValues",
        data: '{"ID":' + sessionStorage["ItemsID"] + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            var obj = eval("(" + result.d + ")");
            sessionStorage["firstv"] = obj.first;
            //alert(sessionStorage["firstv"]);
            sessionStorage["secondv"] = obj.second;
            //alert(sessionStorage["secondv"]);
            sessionStorage["thirdv"] = obj.third;
            //alert(sessionStorage["thirdv"]);
            sessionStorage["forthv"] = obj.forth;
            //alert(sessionStorage["forthv"]);
            sessionStorage["fifthv"] = obj.fifth;
            //alert(sessionStorage["fifthv"]);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}


//加载参评人员
function loadjoiner() {
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../CommentService.asmx/getjoiner",
        data: '{}',
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


//提交评分
function tijiao() {
    //alert("diaoyong:"+iscancomment());
    if (iscancomment()) {
        if (islegal()) {
            //alert("当前Id:" + sessionStorage["ItemsID"]);
            var x = document.getElementById('table_test').rows.length;
            var values = new Array();
            for (var i = 1; i < x; i++) {
                var tableId = document.getElementById("table_test");
                var name = tableId.rows[i].cells[0].innerHTML;
                var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
                for (var j = 0; j < content.length; j++) {
                    if (content[j].type == "text") {
                        values[j] = content[j].value;
                    }
                }
                //string actor, string passive, int itemsid, int first, int second, int third, int forth, int fifth
                $.ajax({
                    type: "post",
                    contentType: "application/json",
                    url: "../../CommentService.asmx/addrecord",
                    data: '{"actor":"' + sessionStorage["username"] + '","passive":"' + name + '","itemsid":' + sessionStorage["ItemsID"] + ',"first":' + values[0] + ',"second":' + values[1] + ',"third":' + values[2] + ',"forth":' + values[3] + ',"fifth":' + values[4] + '}',
                    dataType: "json",
                    async: false,
                    success: function (result) {
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(XMLHttpRequest.status);
                        alert(XMLHttpRequest.readyState);
                        alert(textStatus);
                    }
                })
            }

            $.ajax({
                type: "post",
                contentType: "application/json",
                url: "../../CommentService.asmx/SetNotSubmiy",
                data: '{"username":"' + sessionStorage["username"] + '"}',
                dataType: "json",
                async: false,
                success: function (result) {
                    //alert("设置不可评分成功");
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert(XMLHttpRequest.status);
                    alert(XMLHttpRequest.readyState);
                    alert(textStatus);
                }
            })
            alert("提交成功,请退出系统，以免重复评分");
        }
    }
    else {
        alert("你已经提交评分，不可重复提交");
    }
    //var a = 9;
    //var b = 10;
    //if (a >= 0 && a <= 20) {
    //    alert("a合法");
    //}
    //else {
    //    alert("a不合法");
    //}
    //if (b >= 0 && b <= 20) {
    //    alert("b合法");
    //}
    //else {
    //    alert("b不合法");
    //}

}



//判断数据是否成功
function islegal() {
    var x = document.getElementById('table_test').rows.length;
    var values = new Array();
    for (var i = 1; i < x; i++) {
        var tableId = document.getElementById("table_test");
        var name = tableId.rows[i].cells[0].innerHTML;
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        for (var j = 0; j < content.length; j++) {
            if (content[j].type == "text") {
                switch (j) {
                    case 0: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["firstv"])) { } else { alert("存在数据不合法，请检查后重新提交~第一列"); return false; }; break;
                    case 1: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["secondv"])) { } else { alert("存在数据不合法，请检查后重新提交~第二列"); return false; }; break;
                    case 2: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["thirdv"])) { } else { alert("存在数据不合法，请检查后重新提交~第三列"); return false; }; break;
                    case 3: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["forthv"])) { } else { alert("存在数据不合法，请检查后重新提交~第四列"); return false; }; break;
                    case 4: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["fifthv"])) { } else { alert("存在数据不合法，请检查后重新提交~第五列"); return false; }; break;
                    default: break;
                }
            }
        }
    }
    return true;
}


//判断是否可以提交
function iscancomment() {
    var iscan=false;
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../CommentService.asmx/GetIsCanComment",
        data: '{"username":"' + sessionStorage["username"] + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            //alert("ajax:"+result.d);
            iscan = result.d;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
    return iscan;
}