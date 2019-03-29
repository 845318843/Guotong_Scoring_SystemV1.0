

function check() {
    var checkbox = document.getElementById('select_all');//
    if (checkbox.checked) {
        //alert("选中");
        var x = document.getElementById("table_test").rows.length;
        //alert(x);
        for (var i = 1; i < x - 1; i++) {
            //alert(i);
            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
            var len = content.length;
            for (var j = 0; j < len; j++) {
                if (content[j].type == 'checkbox') {
                    content[j].checked = true;
                }
            }
        }
    }
    else {
        //alert("没选中");
        var x = document.getElementById("table_test").rows.length;
        //alert(x);
        for (var i = 1; i < x - 1; i++) {
            //alert(i);
            var content = document.getElementById('table_test').rows[i].getElementsByTagName('input');
            var len = content.length;
            for (var j = 0; j < len; j++) {
                if (content[j].type == 'checkbox') {
                    content[j].checked = false;
                }
            }
        }

        //content.removeAttr("checked");
    }
}


function select_chengxin() {
    var myselect = document.getElementById('chengxin');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;
    
    if (index == 3) {
        showdialog();
    }
    else {
        //var y = document.getElementById("table_test").rows[0].length;
        for (var i = 1; i < x - 1; i++) {
            var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
            if (content[0].type == 'text') {
                content[0].value = _value;
            }
        }
    }

}


function select_jinqian() {
    
    var myselect = document.getElementById('jinqian');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;
    alert(index);
    //var y = document.getElementById("table_test").rows[0].length;
    for (var i = 1; i < x - 1; i++) {
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        if (content[1].type == 'text') {
            content[1].value = _value;
        }
    }
}


function select_guize() {
    var myselect = document.getElementById('guize');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;

    //var y = document.getElementById("table_test").rows[0].length;
    for (var i = 1; i < x - 1; i++) {
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        if (content[2].type == 'text') {
            content[2].value = _value;
        }
    }
}


function select_weizhi() {
    var myselect = document.getElementById('weizhi');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;

    //var y = document.getElementById("table_test").rows[0].length;
    for (var i = 1; i < x - 1; i++) {
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        if (content[3].type == 'text') {
            content[3].value = _value;
        }
    }
}

function select_nengli() {
    var myselect = document.getElementById('nengli');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;

    //var y = document.getElementById("table_test").rows[0].length;
    for (var i = 1; i < x - 1; i++) {
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        if (content[4].type == 'text') {
            content[4].value = _value;
        }
    }
}

function showdialog() {
    alert("他那就看");
    $("#TanChuang").dialog({
        title: "设置默认值",
        width: 300,
        height: 200,
        modal: true,
        minimizable: true,
        maximizable: true,
        resizable: true,
        buttons: [
            {
                text: "关闭",
                iconCls: "icon-ok",
                hander: function () {
                    alert("modif");
                }
            }, {
                text: "确认",
                iconCls: "icon-cancle",
                hander: function () {
                    $("#TanChuang").dialog("close");
                }
            }
        ]
    })
}
//$(function () {
//    //var x = document.getElementById("table_test").rows[1].getElementsByTagName('input');
//    //alert(x[1].value);

//    var row_count = document.getElementById('table_test').rows.length;
//    alert('123445');
//    var Obox = document.getElementById('select_all');

//    Obox.click() = function () {
//        if ($(this).Attr('checked')=='checked') {
//            alert('123');
//            select_all();
//        }
//        else {
//        }
//    };
//})
//function select_all() {
//    var x = document.getElementById("table_test").rows.length;
//    for (var i = 1; i < x - 1; i++) {
//        var content = document.getElementById('table_test').rows[i].cells[6].getElementsByTagName('checkbox');
//        content.checked = true;
//    }
//}
