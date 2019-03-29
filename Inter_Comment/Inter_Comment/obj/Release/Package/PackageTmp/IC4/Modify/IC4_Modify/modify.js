/// <reference path="../../../IC2/Login/IC2_Login/login.html" />
/// <reference path="../../../ModifyService.asmx" />
function modifypwd() {
    var oldpwd = $("#oldpwd").val();
    var newpwd = $("#newpwd").val();
    var repeatpwd = $("#repeatpwd").val();
    if (sessionStorage["identify"] == "普通用户") {
        if (oldpwd == sessionStorage["pwd"]) {
            if (newpwd == repeatpwd) {
                if (newpwd != "") {
                    $.ajax({
                        type: "post",
                        contentType: "application/json",
                        url: "../../../ModifyService.asmx/ModifyUserPwd",
                        data: '{"username":"' + sessionStorage["username"] + '","pwd":"' + newpwd + '"}',
                        dataType: "json",
                        async: false,
                        success: function (result) {
                            
                            alert(result.d);
                            if (result.d == "密码修改成功") {
                                
                                window.location.href = "../../../IC2/Login/IC2_Login/login.html";
                            }
                        },
                        error: function (result) {
                            alert("error");
                        }
                    })
                }
                else {
                    alert("密码不能为空");
                }
            }
            else {
                alert("两次密码不一致");
            }

        }
        else {
            alert("旧密码输入错误");
        }
    }
   else if (sessionStorage["identify"] == "普通管理员"||sessionStorage["identify"]=="高级管理员") {
        if (oldpwd == sessionStorage["pwd"]) {
            if (newpwd == repeatpwd) {
                if (newpwd != "") {
                    $.ajax({
                        type: "post",
                        contentType: "application/json",
                        url: "../../../ModifyService.asmx/ModifyAdminPwd",
                        data: '{"account":"' + sessionStorage["username"] + '","pwd":"' + newpwd + '"}',
                        dataType: "json",
                        async: false,
                        success: function (result) {
                            alert(result.d);
                            if (result.d == "密码修改成功") {
                                window.location.href = "../../../IC2/Login/IC2_Login/login.html";
                            }
                        },
                        error: function (result) {
                        }
                    })
                }
                else {
                    alert("密码不能为空");
                }
            }
            else {
                alert("两次密码不一致");
            }

        }
        else {
            alert("旧密码输入错误");
        }
    }
}