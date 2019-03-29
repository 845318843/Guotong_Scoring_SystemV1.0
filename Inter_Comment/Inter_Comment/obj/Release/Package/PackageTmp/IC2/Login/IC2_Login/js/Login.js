/// <reference path="../../../../Comment/comment.html" />
/// <reference path="../../../../IC6/AdministratorPage/IC6_AdminHome/adminhome.html" />
/// <reference path="../../../../IC5/Select/IC5_Select/select.html" />
/// <reference path="../../../../IC1/comment.html" />
/// <reference path="../../../../LoginService.asmx" />
/// <reference path="../../../../CommentService.asmx" />
//普通用户登录
function userlogin() {
    var username = "";
    var pwd = "";
    username = $("#username").val();
    pwd = $("#pwd").val();
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../../../LoginService.asmx/UserLogin",
        data: '{"username":"' + username + '","pwd":"' + pwd + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == "登录成功") {

                $.ajax({
                    type: "post",
                    contentType: "application/json",
                    url: "../../../../LoginService.asmx/Is_CanComment",
                    data: '{"username":"' + username + '"}',
                    dataType: "json",
                    async: false,
                    success: function (result) {
                        if (!result.d) {
                            alert("您暂时不可登录系统");
                        }
                        else {
                            //alert("登录成功");
                            sessionStorage["islogin"] = "true";
                            getitemsid();
                            sessionStorage["username"] = username;
                            sessionStorage["pwd"] = pwd;
                            sessionStorage["identify"] = "普通用户";
                            window.location.href = "../../../../Comment/comment.html";

                        }
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(XMLHttpRequest.status);
                        alert(XMLHttpRequest.readyState);
                        alert(textStatus);
                    }
                })


            }
            else if (result.d == "登录失败") {
                alert("用户名或密码错误");
            }
        },
        error: function (result) {
        }
    })

}

//管理员登录
function adminlogin() {
    var username = "";
    var pwd = "";
    username = $("#username").val();
    pwd = $("#pwd").val();
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../../../LoginService.asmx/AdminLogin",
        data: '{"account":"' + username + '","pwd":"' + pwd + '"}',
        dataType: "json",
        async: false,
        success: function (result) {
            if (result.d == "") {
                sessionStorage["role"] = "";
                alert("账号或密码错误");
            }
            else {
                sessionStorage["role"] = result.d;
                sessionStorage["username"] = username;
                sessionStorage["pwd"] = pwd;
                sessionStorage["identify"] = result.d;
                window.location.href = "../../../../IC6/AdministratorPage/IC6_AdminHome/adminhome.html";
            }
        },
        error: function (result) {
            alert("账号或密码错误");
        }
    })

};


//获取启动项id
function getitemsid() {
$.ajax({
    type: "post",
    contentType: "application/json",
    url: "../../../../CommentService.asmx/GetItemsID",
    data: '{}',
    dataType: "json",
    async: false,
    success: function (result) {
        sessionStorage["ItemsID"] = result.d;
        
    },
    error: function (XMLHttpRequest, textStatus, errorThrown) {
        alert(XMLHttpRequest.status);
        alert(XMLHttpRequest.readyState);
        alert(textStatus);
    }
})
}





