/// <reference path="../../Set2Service.asmx" />
/// <reference path="../../CommentService.asmx" />
/// <reference path="../../CommentService.asmx" />
//加载项目组
function loaditem() {
    //alert("加载项目组");
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
    //alert("加载标题");
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
            //loadvalues();
            loaditem();

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
    //alert("记载最大分值");
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../Set2Service.asmx/GetMoreScoreById",
        data: '{"id":' + sessionStorage["ItemsID"] + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            var obj = eval("(" + result.d + ")");
            sessionStorage["FirstValue"] = obj.First_Value;
            sessionStorage["FirstSub1"] = obj.First_Sub1;
            sessionStorage["FirstSub2"] = obj.First_Sub2;
            sessionStorage["FirstSub3"] = obj.First_Sub3;
            sessionStorage["FirstSub4"] = obj.First_Sub4;
            sessionStorage["FirstSub5"] = obj.First_Sub5;

            sessionStorage["SecondValue"] = obj.Second_Value;
            sessionStorage["SecondSub1"] = obj.Second_Sub1;
            sessionStorage["SecondSub2"] = obj.Second_Sub2;
            sessionStorage["SecondSub3"] = obj.Second_Sub3;
            sessionStorage["SecondSub4"] = obj.Second_Sub4;
            sessionStorage["SecondSub5"] = obj.Second_Sub5;

            sessionStorage["ThirdValue"] = obj.Third_Value;
            sessionStorage["ThirdSub1"] = obj.Third_Sub1;
            sessionStorage["ThirdSub2"] = obj.Third_Sub2;
            sessionStorage["ThirdSub3"] = obj.Third_Sub3;
            sessionStorage["ThirdSub4"] = obj.Third_Sub4;
            sessionStorage["ThirdSub5"] = obj.Third_Sub5;

            sessionStorage["ForthValue"] = obj.Forth_Value;
            sessionStorage["ForthSub1"] = obj.Forth_Sub1;
            sessionStorage["ForthSub2"] = obj.Forth_Sub2;
            sessionStorage["ForthSub3"] = obj.Forth_Sub3;
            sessionStorage["ForthSub4"] = obj.Forth_Sub4;
            sessionStorage["ForthSub5"] = obj.Forth_Sub5;

            sessionStorage["FifthValue"] = obj.Fifth_Value;
            sessionStorage["FifthSub1"] = obj.Fifth_Sub1;
            sessionStorage["FifthSub2"] = obj.Fifth_Sub2;
            sessionStorage["FifthSub3"] = obj.Fifth_Sub3;
            sessionStorage["FifthSub4"] = obj.Fifth_Sub4;
            sessionStorage["FifthSub5"] = obj.Fifth_Sub5;
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
    //alert("加载参评人员");
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
        //空白项自动补零
        fillwithzero();
        if (islegal()) {
            if ((!isdifferent_small()) && (!isdifferent_big())) {
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
                    var first_value = Number(values[0]) + Number(values[1]) + Number(values[2]) + Number(values[3]) + Number(values[4]);
                    var second_value = Number(values[5]) + Number(values[6]) + Number(values[7]) + Number(values[8]) + Number(values[9]);
                    var third_value = Number(values[10]) + Number(values[11]) + Number(values[12]) + Number(values[13]) + Number(values[14]);
                    var forth_value = Number(values[15]) + Number(values[16]) + Number(values[17]) + Number(values[18]) + Number(values[19]);
                    var fifth_value = Number(values[20]) + Number(values[21]) + Number(values[22]) + Number(values[23]) + Number(values[24]);
                    //    string actor, string passive, int itemsid, int first_item, int first_sub1, int first_sub2, int first_sub3, int first_sub4, int first_sub5,
                    //int second_item, int second_sub1, int second_sub2, int second_sub3, int second_sub4, int second_sub5,
                    //int third_item, int third_sub1, int third_sub2, int third_sub3, int third_sub4, int third_sub5,
                    //int forth_item, int forth_sub1, int forth_sub2, int forth_sub3, int forth_sub4, int forth_sub5,
                    //int fifth_item, int fifth_sub1, int fifth_sub2, int fifth_sub3, int fifth_sub4, int fifth_sub5
                    $.ajax({
                        type: "post",
                        contentType: "application/json",
                        url: "../../CommentService.asmx/addrecord",
                        data: '{"actor":"' + sessionStorage["username"] + '","passive":"' + name + '","itemsid":' + sessionStorage["ItemsID"] + ',"first_item":' + first_value + ',"first_sub1":' + values[0] + ',"first_sub2":' + values[1] + ',"first_sub3":' + values[2] + ',"first_sub4":' + values[3] + ',"first_sub5":' + values[4] + ',  "second_item":' + second_value + ',"second_sub1":' + values[5] + ',"second_sub2":' + values[6] + ',"second_sub3":' + values[7] + ',"second_sub4":' + values[8] + ',"second_sub5":' + values[9] + ',  "third_item":' + third_value + ',"third_sub1":' + values[10] + ',"third_sub2":' + values[11] + ',"third_sub3":' + values[12] + ',"third_sub4":' + values[13] + ',"third_sub5":' + values[14] + ',  "forth_item":' + forth_value + ',"forth_sub1":' + values[15] + ',"forth_sub2":' + values[16] + ',"forth_sub3":' + values[17] + ',"forth_sub4":' + values[18] + ',"forth_sub5":' + values[19] + ',  "fifth_item":' + fifth_value + ',"fifth_sub1":' + values[20] + ',"fifth_sub2":' + values[21] + ',"fifth_sub3":' + values[22] + ',"fifth_sub4":' + values[23] + ',"fifth_sub5":' + values[24] + '}',
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
        }
        else {
            alert("你已经提交评分，不可重复提交");
        }
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
    values = [4, 4, 4, 4, 4, 5, 5, 5, 5, 0, 10, 10, 0, 0, 0, 20, 0, 0, 0, 0, 10, 10, 0, 0, 0];
    for (var i = 1; i < x; i++) {
        var tableId = document.getElementById("table_test");
        var name = tableId.rows[i].cells[1].innerHTML;
        //alert(name);
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        var contents = document.getElementById("table_test").rows[i].cells[0];

        for (var j = 0; j < content.length; j++) {
            if (content[j].type == "text") {
                switch (j) {
                    case 0: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FirstSub1"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 1: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FirstSub2"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 2: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FirstSub3"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 3: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FirstSub4"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 4: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FirstSub5"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;

                    case 5: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["SecondSub1"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 6: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["SecondSub2"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 7: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["SecondSub3"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 8: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["SecondSub4"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 9: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["SecondSub5"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;

                    case 10: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ThirdSub1"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 11: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ThirdSub2"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 12: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ThirdSub3"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 13: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ThirdSub4"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 14: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ThirdSub5"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;

                    case 15: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ForthSub1"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 16: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ForthSub2"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 17: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ForthSub3"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 18: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ForthSub4"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 19: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["ForthSub5"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;

                    case 20: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FifthSub1"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 21: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FifthSub2"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 22: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FifthSub3"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 23: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FifthSub4"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    case 24: if ((Number(content[j].value) >= 0) && (Number(content[j].value) <= sessionStorage["FifthSub5"]) && isInteger(content[j].value)) { } else { alert("存在数据不合法，请检查后重新提交~第" + i + "行第" + (Number(j) + 1) + "列"); return false; }; break;
                    default: break;
                }

                //if ((Number(content[j].value) <= values[j])&&(Number(content[j].value)>=0)) {
                //    alert(content[j].value);
                //}
                //else {
                //    alert("存在不合法数据，第" + i + "行第" + j + "列");
                //}
            }
        }
    }
    return true;
}

function tijiao1() {
    fillwithzero();
    alert(isdifferent_big());
    alert(isdifferent_small());
}


//每小项无差异化判断 无差异则返回真
function isdifferent_small() {
    var x = document.getElementById('table_test').rows.length;
    for (var i = 1; i < x; i++) {
        var temp;
        var ischongfu = true;
        var start = true;
        var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
        for (var j = 0; j < content.length; j++) {
            if (content[j].type == "text") {
                if (start) {
                    temp = content[j].value;
                    start = false;
                    //alert("第一步");
                }
                else {
                    if (Number(content[j].value) != Number(temp)) {
                        ischongfu = false;
                        //alert("第二步");
                    }
                }
            }
        }
        if (ischongfu == true) {
            //alert("第三步");
            //alert('123');
            alert("你给第" + i + "个人打的所有分数都一样，这样是不允许的哦");
            return true;
        }
    }
    return false;

}

//每大项无差异化判断 无差异则返回真
function isdifferent_big() {
    var x = document.getElementById('table_test').rows.length;
    for (var i = 1; i < x; i++) {

        var shuzu = new Array();
        var zongfen = 0;
        var zizeng = 0;
        var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
        for (var j = 0; j < content.length; j++) {
            zongfen += Number(content[j].value);
            if ((j + 1) % 5 == 0) {
                shuzu[zizeng] = zongfen;
                zizeng++;
                zongfen = 0;
            }

        }
        if ((Number(shuzu[0]) == Number(sessionStorage["FirstValue"])) && (Number(shuzu[1]) == Number(sessionStorage["SecondValue"])) && (Number(shuzu[2]) == Number(sessionStorage["ThirdValue"])) && (Number(shuzu[3]) == Number(sessionStorage["ForthValue"])) && (Number(shuzu[4]) == Number(sessionStorage["FifthValue"]))) {
            alert("你给第" + i + "个人所有项目打的都是满分，这样是不允许的哦");
            return true;
        }


    }
    return false;

}

//空白自动补零
function fillwithzero() {
    var x = document.getElementById('table_test').rows.length;
    for (var i = 1; i < x; i++) {
        var tableId = document.getElementById("table_test");
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        for (var j = 0; j < content.length; j++) {
            if (content[j].type == "text") {
                if (content[j].value == "") {
                    content[j].value = 0;
                }
            }
        }
    }
}



//判断是否可以提交
function iscancomment() {
    var iscan = false;
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


//判断函数
function isInteger(obj) {
    return (obj % 1 === 0) && (Number(obj) >= 0);
}