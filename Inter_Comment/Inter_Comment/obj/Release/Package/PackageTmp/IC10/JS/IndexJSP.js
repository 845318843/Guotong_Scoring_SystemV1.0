/// <reference path="../../DeleteService.asmx" />
/// <reference path="../../../../SetService.asmx" />
/// <reference path="../../../../SetService.asmx" />
//function check1() {
//    var checkbox1 = document.getElementById('select_all1');//
//    if (checkbox1.checked) {
//        //alert("选中");
//        var x = document.getElementById("table_test").rows.length;
//        //alert(x);
//        for (var i = 1; i < x - 1; i++) {
//            //alert(i);
//            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
//            var len = content.length;
//            for (var j = 0; j < len; j++) {
//                if (content[j].type == 'checkbox') {
//                    if (Number(j) == 0) {
//                        content[j].checked = true;
//                    }
//                }
//            }
//        }
//    }
//    else {
//        //alert("没选中");
//        var x = document.getElementById("table_test").rows.length;
//        //alert(x);
//        for (var i = 1; i < x - 1; i++) {
//            //alert(i);
//            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
//            var len = content.length;
//            for (var j = 0; j < len; j++) {
//                if (content[j].type == 'checkbox') {
//                    if (Number(j) == 0) {
//                        content[j].checked = false;
//                    }
//                }
//            }
//        }

//        content.removeAttr("checked");
//    }
//}


//function check2() {
//    var checkbox2 = document.getElementById('select_all2');//
//    if (checkbox2.checked) {
//        //alert("选中");
//        var x = document.getElementById("table_test").rows.length;
//        //alert(x);
//        for (var i = 1; i < x - 1; i++) {
//            //alert(i);
//            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
//            var len = content.length;
//            for (var j = 0; j < len; j++) {
//                if (content[j].type == 'checkbox') {
//                    if (Number(j) == 1) {
//                        content[j].checked = true;
//                    }
//                }
//            }
//        }
//    }
//    else {
//        //alert("没选中");
//        var x = document.getElementById("table_test").rows.length;
//        //alert(x);
//        for (var i = 1; i < x - 1; i++) {
//            //alert(i);
//            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
//            var len = content.length;
//            for (var j = 0; j < len; j++) {
//                if (content[j].type == 'checkbox') {
//                    if (Number(j) == 1) {
//                        content[j].checked = false;
//                    }
//                }
//            }
//        }

//        content.removeAttr("checked");
//    }
//}


//function select_nengli() {
//    var myselect = document.getElementById('nengli');
//    var index = myselect.selectedIndex;
//    var _value = myselect.options[index].value;
//    var x = document.getElementById("table_test").rows.length;

//    //var y = document.getElementById("table_test").rows[0].length;
//    for (var i = 1; i < x - 1; i++) {
//        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
//        if (content[4].type == 'text') {
//            content[4].value = _value;
//        }
//    }
//}


function tijiao() {
    var x = document.getElementById("table_test").rows.length;
    //alert(x);
    for (var i = 1; i < x; i++) {
        var tableId = document.getElementById("table_test");
        var userid = tableId.rows[i].cells[0].innerHTML;
        var attribute = tableId.rows[i].cells[2].innerHTML;
        //alert(i);
        var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
        var len = content.length;
        for (var j = 0; j < len; j++) {
            if (content[j].type == 'checkbox') {
                if (content[j].checked) {
                    //第一个复选框
                    if (attribute=="普通用户") {
                        $.ajax({
                            type: "post",
                            contentType: "application/json",
                            url: "../../DeleteService.asmx/DeleteStaffById",
                            data: '{"ID":' + userid + '}',
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
                    else if(attribute=="系统管理员") {
                        $.ajax({
                            type: "post",
                            contentType: "application/json",
                            url: "../../DeleteService.asmx/DeleteAdminById",
                            data: '{"ID":' + userid + '}',
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
                }
            }
        }
        
    }
    alert("设置成功");
    window.location.reload();
}


function test() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../../SetService.asmx/ddd",
    data: '{"UserID":"123"}',
    dataType: "json",
    async: false,
    success: function (result) {
        alert("成功");
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}
