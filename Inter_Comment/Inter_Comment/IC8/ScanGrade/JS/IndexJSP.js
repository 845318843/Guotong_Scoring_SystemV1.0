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

        content.removeAttr("checked");
    }
}

function select_chengxin() {
    
    var myselect = document.getElementById('chengxin');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;
    
    //var y = document.getElementById("table_test").rows[0].length;
    for (var i = 1; i < x - 1; i++) {
        var content = document.getElementById("table_test").rows[i].getElementsByTagName('input');
        if (content[0].type == 'text') {
            content[0].value = _value;
        }
    }

}

function select_jinqian() {
    var myselect = document.getElementById('jinqian');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var x = document.getElementById("table_test").rows.length;

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
