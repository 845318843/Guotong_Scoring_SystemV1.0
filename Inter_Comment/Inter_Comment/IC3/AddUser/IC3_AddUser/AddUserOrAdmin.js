/// <reference path="../../../IC10/delete.html" />
/// <reference path="../../../IC4/Modify/IC4_Modify/modify.html" />
/// <reference path="../../../IC5/Select/IC5_Select/select.html" />
/// <reference path="../../../AddService.asmx" />
var cunzai = true;
function add() {
    var myselect = document.getElementById('types');
    var index = myselect.selectedIndex;
    var _value = myselect.options[index].value;
    var username = $("#active").val();
    var pwd = $("#pwd").val();
    if (username != "" && pwd != ""&&username!="姓名"&&pwd!="密码") {
        switch (index) {
            case 0: userisexist(); adduser();  break;
            case 1:  adminisexist();   addadmin(); break;
            case 2:  adminisexist();  addadmin();  break;
            default: break;
        }
    }
    else {
        alert("用户名或密码不能为空！");
    }

}


//判断用户是否存在
function userisexist(){
    var username=$("#active").val();
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../AddService.asmx/UserIsExist",
    data: '{"username":"'+username+'"}',
    dataType: "json",
    async: false,
    success: function (result) {
        if(result.d==true){
            alert("该用户已经存在，不能重复注册");
            cunzai=true;
        }
        else{
            cunzai= false;
        }
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})

}



//判断管理员是否存在
function adminisexist() {
    //alert("判断管理员");
    var username=$("#active").val();
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../../AddService.asmx/AdminIsExist",
        data: '{"username":"'+username+'"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if(result.d==true){
                alert("该用户已经存在，不能重复注册");
                cunzai= true;
            }
            else{
                cunzai= false;
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })

}


//添加用户
function adduser() {
    if (!cunzai) {
        var username = $("#active").val();
        var pwd = $("#pwd").val();
        $.ajax({
            type: "post",
            contentType: "application/json",
            url: "../../../AddService.asmx/AddUser",
            data: '{"username":"' + username + '","pwd":"' + pwd + '"}',
            dataType: "json",
            async: false,
            success: function (result) {
                if (result.d) {
                    alert("添加成功");
                }
                else {
                    alert("添加失败");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
            }
        })
    }
    else { }
}


//添加管理员
function addadmin() {
    if (!cunzai) {
        var username = $("#active").val();
        var pwd = $("#pwd").val();
        var myselect = document.getElementById('types');
        var index = myselect.selectedIndex;
        var _value = myselect.options[index].value;
        $.ajax({
            type: "post",
            contentType: "application/json",
            url: "../../../AddService.asmx/AddAdmin",
            data: '{"username":"' + username + '","pwd":"' + pwd + '","role":"' + _value + '"}',
            dataType: "json",
            async: false,
            success: function (result) {
                if (result.d) {
                    alert("添加成功");
                }
                else {
                    alert("添加失败");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
            }
        })
    }
    else { }
}


//跳转到设置人员是否参评页面
function jumptoset() {

    window.location.href = "../../../IC5/Select/IC5_Select/select.html";
}



//跳转到修改密码页面
function jumptoalter() {
    window.location.href = "../../../IC4/Modify/IC4_Modify/modify.html";
}


//跳转到删除页面
function jumptodelete() {
    window.location.href = "../../../IC10/delete.html";

}