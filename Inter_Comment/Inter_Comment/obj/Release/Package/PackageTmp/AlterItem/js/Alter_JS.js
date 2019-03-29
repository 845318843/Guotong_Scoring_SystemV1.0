/// <reference path="../../ScanService.asmx" />
/// <reference path="../../Set2Service.asmx" />
//function alter() {
//    var theme = document.getElementById('theme').value;
//    var first_key = document.getElementById('first_key').value;
//    var first_sub1 = document.getElementById('first_sub1').value;
//    var first_sub2 = document.getElementById('first_sub2').value;
//    var first_sub3 = document.getElementById('first_sub3').value;
//    var first_sub4 = document.getElementById('first_sub4').value;
//    var first_sub5 = document.getElementById('first_sub5').value;
//    var first_sub1_value = document.getElementById('first_sub1_value').value;
//    var first_sub2_value = document.getElementById('first_sub2_value').value;
//    var first_sub3_value = document.getElementById('first_sub3_value').value;
//    var first_sub4_value = document.getElementById('first_sub4_value').value;
//    var first_sub5_value = document.getElementById('first_sub5_value').value;

//    var second_key = document.getElementById('second_key').value;
//    var second_sub1 = document.getElementById('second_sub1').value;
//    var second_sub2 = document.getElementById('second_sub2').value;
//    var second_sub3 = document.getElementById('second_sub3').value;
//    var second_sub4 = document.getElementById('second_sub4').value;
//    var second_sub5 = document.getElementById('second_sub5').value;
//    var second_sub1_value = document.getElementById('second_sub1_value').value;
//    var second_sub2_value = document.getElementById('second_sub2_value').value;
//    var second_sub3_value = document.getElementById('second_sub3_value').value;
//    var second_sub4_value = document.getElementById('second_sub4_value').value;
//    var second_sub5_value = document.getElementById('second_sub5_value').value;


//    var third_key = document.getElementById('third_key').value;
//    var third_sub1 = document.getElementById('third_sub1').value;
//    var third_sub2 = document.getElementById('third_sub2').value;
//    var third_sub3 = document.getElementById('third_sub3').value;
//    var third_sub4 = document.getElementById('third_sub4').value;
//    var third_sub5 = document.getElementById('third_sub5').value;
//    var third_sub1_value = document.getElementById('third_sub1_value').value;
//    var third_sub2_value = document.getElementById('third_sub2_value').value;
//    var third_sub3_value = document.getElementById('third_sub3_value').value;
//    var third_sub4_value = document.getElementById('third_sub4_value').value;
//    var third_sub5_value = document.getElementById('third_sub5_value').value;


//    var forth_key = document.getElementById('forth_key').value;
//    var forth_sub1 = document.getElementById('forth_sub1').value;
//    var forth_sub2 = document.getElementById('forth_sub2').value;
//    var forth_sub3 = document.getElementById('forth_sub3').value;
//    var forth_sub4 = document.getElementById('forth_sub4').value;
//    var forth_sub5 = document.getElementById('forth_sub5').value;
//    var forth_sub1_value = document.getElementById('forth_sub1_value').value;
//    var forth_sub2_value = document.getElementById('forth_sub2_value').value;
//    var forth_sub3_value = document.getElementById('forth_sub3_value').value;
//    var forth_sub4_value = document.getElementById('forth_sub4_value').value;
//    var forth_sub5_value = document.getElementById('forth_sub5_value').value;


//    var fifth_key = document.getElementById('fifth_key').value;
//    var fifth_sub1 = document.getElementById('fifth_sub1').value;
//    var fifth_sub2 = document.getElementById('fifth_sub2').value;
//    var fifth_sub3 = document.getElementById('fifth_sub3').value;
//    var fifth_sub4 = document.getElementById('fifth_sub4').value;
//    var fifth_sub5 = document.getElementById('fifth_sub5').value;
//    var fifth_sub1_value = document.getElementById('fifth_sub1_value').value;
//    var fifth_sub2_value = document.getElementById('fifth_sub2_value').value;
//    var fifth_sub3_value = document.getElementById('fifth_sub3_value').value;
//    var fifth_sub4_value = document.getElementById('fifth_sub4_value').value;
//    var fifth_sub5_value = document.getElementById('fifth_sub5_value').value;

//    alert(theme);
//    alert(first_key);
//    alert(first_sub1);
//    alert(first_sub1_value);
//    alert(first_sub2);
//    alert(first_sub2_value);
//    alert(first_sub3);
//    alert(first_sub3_value);
//    alert(first_sub4);
//    alert(first_sub4_value);
//    alert(first_sub5);
//    alert(first_sub5_value);


//    alert(second_key);
//    alert(second_sub1);
//    alert(second_sub1_value);
//    alert(second_sub2);
//    alert(second_sub2_value);
//    alert(second_sub3);
//    alert(second_sub3_value);
//    alert(second_sub4);
//    alert(second_sub4_value);
//    alert(second_sub5);
//    alert(second_sub5_value);


//    alert(third_key);
//    alert(third_sub1);
//    alert(third_sub1_value);
//    alert(third_sub2);
//    alert(third_sub2_value);
//    alert(third_sub3);
//    alert(third_sub3_value);
//    alert(third_sub4);
//    alert(third_sub4_value);
//    alert(third_sub5);
//    alert(third_sub5_value);


//    alert(forth_key);
//    alert(forth_sub1);
//    alert(forth_sub1_value);
//    alert(forth_sub2);
//    alert(forth_sub2_value);
//    alert(forth_sub3);
//    alert(forth_sub3_value);
//    alert(forth_sub4);
//    alert(forth_sub4_value);
//    alert(forth_sub5);
//    alert(forth_sub5_value);


//    alert(fifth_key);
//    alert(fifth_sub1);
//    alert(fifth_sub1_value);
//    alert(fifth_sub2);
//    alert(fifth_sub2_value);
//    alert(fifth_sub3);
//    alert(fifth_sub3_value);
//    alert(fifth_sub4);
//    alert(fifth_sub4_value);
//    alert(fifth_sub5);
//    alert(fifth_sub5_value);
//}



/// <reference path="../../Set2Service.asmx" />
var _value = 99999;
//修改项目组
function alter() {
    FillwithZero();
    if (!islegal()) {
        alert("您填写的分值有误，请检查后重新填写");
    }
    else {
        var theme = document.getElementById('themetext').value;

        var first_sub1_value = document.getElementById('first_sub1_value').value;
        var first_sub2_value = document.getElementById('first_sub2_value').value;
        var first_sub3_value = document.getElementById('first_sub3_value').value;
        var first_sub4_value = document.getElementById('first_sub4_value').value;
        var first_sub5_value = document.getElementById('first_sub5_value').value;
        var first_key = document.getElementById('first_key').value;
        if (Number(first_sub1_value) != 0) {
            var first_sub1 = document.getElementById('first_sub1').value + "(" + first_sub1_value + "分)";
        }
        else {
            var first_sub1 = document.getElementById('first_sub1').value;
        }
        if (Number(first_sub2_value) != 0) {
            var first_sub2 = document.getElementById('first_sub2').value + "(" + first_sub2_value + "分)";
        }
        else {
            var first_sub2 = document.getElementById('first_sub2').value;
        }
        if (Number(first_sub3_value) != 0) {
            var first_sub3 = document.getElementById('first_sub3').value + "(" + first_sub3_value + "分)";
        }
        else {
            var first_sub3 = document.getElementById('first_sub3').value;
        }
        if (Number(first_sub4_value) != 0) {
            var first_sub4 = document.getElementById('first_sub4').value + "(" + first_sub4_value + "分)";
        }
        else {
            var first_sub4 = document.getElementById('first_sub4').value;
        }
        if (Number(first_sub5_value) != 0) {
            var first_sub5 = document.getElementById('first_sub5').value + "(" + first_sub5_value + "分)";
        }
        else {
            var first_sub5 = document.getElementById('first_sub5').value;
        }
        var first = first_key + first_sub1 + first_sub2 + first_sub3 + first_sub4 + first_sub5;
        var first_value = Number(first_sub1_value) + Number(first_sub2_value) + Number(first_sub3_value) + Number(first_sub4_value) + Number(first_sub5_value);


        var second_sub1_value = document.getElementById('second_sub1_value').value;
        var second_sub2_value = document.getElementById('second_sub2_value').value;
        var second_sub3_value = document.getElementById('second_sub3_value').value;
        var second_sub4_value = document.getElementById('second_sub4_value').value;
        var second_sub5_value = document.getElementById('second_sub5_value').value;
        var second_key = document.getElementById('second_key').value;

        //var second_sub1 = document.getElementById('second_sub1').value + "(" + second_sub1_value + "分)";
        if (Number(second_sub1_value) != 0) {
            var second_sub1 = document.getElementById('second_sub1').value + "(" + second_sub1_value + "分)";
        }
        else {
            var second_sub1 = document.getElementById('second_sub1').value;
        }
        //var second_sub2 = document.getElementById('second_sub2').value + "(" + second_sub2_value + "分)";
        if (Number(second_sub2_value) != 0) {
            var second_sub2 = document.getElementById('second_sub2').value + "(" + second_sub2_value + "分)";
        }
        else {
            var second_sub2 = document.getElementById('second_sub2').value;
        }
        //var second_sub3 = document.getElementById('second_sub3').value + "(" + second_sub3_value + "分)";
        if (Number(second_sub3_value) != 0) {
            var second_sub3 = document.getElementById('second_sub3').value + "(" + second_sub3_value + "分)";
        }
        else {
            var second_sub3 = document.getElementById('second_sub3').value;
        }
        //var second_sub4 = document.getElementById('second_sub4').value + "(" + second_sub4_value + "分)";
        if (Number(second_sub4_value) != 0) {
            var second_sub4 = document.getElementById('second_sub4').value + "(" + second_sub4_value + "分)";
        }
        else {
            var second_sub4 = document.getElementById('second_sub4').value;
        }
        //var second_sub5 = document.getElementById('second_sub5').value + "(" + second_sub5_value + "分)";
        if (Number(second_sub5_value) != 0) {
            var second_sub5 = document.getElementById('second_sub5').value + "(" + second_sub5_value + "分)";
        }
        else {
            var second_sub5 = document.getElementById('second_sub5').value;
        }
        var second = second_key + second_sub1 + second_sub2 + second_sub3 + second_sub4 + second_sub5;
        var second_value = Number(second_sub1_value) + Number(second_sub2_value) + Number(second_sub3_value) + Number(second_sub4_value) + Number(second_sub5_value);


        var third_key = document.getElementById('third_key').value;
        var third_sub1_value = document.getElementById('third_sub1_value').value;
        var third_sub2_value = document.getElementById('third_sub2_value').value;
        var third_sub3_value = document.getElementById('third_sub3_value').value;
        var third_sub4_value = document.getElementById('third_sub4_value').value;
        var third_sub5_value = document.getElementById('third_sub5_value').value;
        //var third_sub1 = document.getElementById('third_sub1').value + "(" + third_sub1_value + "分)";
        if (Number(third_sub1_value) != 0) {
            var third_sub1 = document.getElementById('third_sub1').value + "(" + third_sub1_value + "分)";
        }
        else {
            var third_sub1 = document.getElementById('third_sub1').value;
        }
        //var third_sub2 = document.getElementById('third_sub2').value + "(" + third_sub2_value + "分)";
        if (Number(third_sub2_value) != 0) {
            var third_sub2 = document.getElementById('third_sub2').value + "(" + third_sub2_value + "分)";
        }
        else {
            var third_sub2 = document.getElementById('third_sub2').value;
        }
        //var third_sub3 = document.getElementById('third_sub3').value + "(" + third_sub3_value + "分)";
        if (Number(third_sub3_value) != 0) {
            var third_sub3 = document.getElementById('third_sub3').value + "(" + third_sub3_value + "分)";
        }
        else {
            var third_sub3 = document.getElementById('third_sub3').value;
        }
        //var third_sub4 = document.getElementById('third_sub4').value + "(" + third_sub4_value + "分)";
        if (Number(third_sub4_value) != 0) {
            var third_sub4 = document.getElementById('third_sub4').value + "(" + third_sub4_value + "分)";
        }
        else {
            var third_sub4 = document.getElementById('third_sub4').value;
        }
        //var third_sub5 = document.getElementById('third_sub5').value + "(" + third_sub5_value + "分)";
        if (Number(third_sub5_value) != 0) {
            var third_sub5 = document.getElementById('third_sub5').value + "(" + third_sub5_value + "分)";
        }
        else {
            var third_sub5 = document.getElementById('third_sub5').value;
        }
        var third = third_key + third_sub1 + third_sub2 + third_sub3 + third_sub4 + third_sub5;
        var third_value = Number(third_sub1_value) + Number(third_sub2_value) + Number(third_sub3_value) + Number(third_sub4_value) + Number(third_sub5_value);


        var forth_key = document.getElementById('forth_key').value;
        var forth_sub1_value = document.getElementById('forth_sub1_value').value;
        var forth_sub2_value = document.getElementById('forth_sub2_value').value;
        var forth_sub3_value = document.getElementById('forth_sub3_value').value;
        var forth_sub4_value = document.getElementById('forth_sub4_value').value;
        var forth_sub5_value = document.getElementById('forth_sub5_value').value;
        //var forth_sub1 = document.getElementById('forth_sub1').value + "(" + forth_sub1_value + "分)";
        if (Number(forth_sub1_value) != 0) {
            var forth_sub1 = document.getElementById('forth_sub1').value + "(" + forth_sub1_value + "分)";
        }
        else {
            var forth_sub1 = document.getElementById('forth_sub1').value;
        }
        //var forth_sub2 = document.getElementById('forth_sub2').value + "(" + forth_sub2_value + "分)";
        if (Number(forth_sub2_value) != 0) {
            var forth_sub2 = document.getElementById('forth_sub2').value + "(" + forth_sub2_value + "分)";
        }
        else {
            var forth_sub2 = document.getElementById('forth_sub2').value;
        }
        //var forth_sub3 = document.getElementById('forth_sub3').value + "(" + forth_sub3_value + "分)";
        if (Number(forth_sub3_value) != 0) {
            var forth_sub3 = document.getElementById('forth_sub3').value + "(" + forth_sub3_value + "分)";
        }
        else {
            var forth_sub3 = document.getElementById('forth_sub3').value;
        }
        //var forth_sub4 = document.getElementById('forth_sub4').value + "(" + forth_sub4_value + "分)";
        if (Number(forth_sub4_value) != 0) {
            var forth_sub4 = document.getElementById('forth_sub4').value + "(" + forth_sub4_value + "分)";
        }
        else {
            var forth_sub4 = document.getElementById('forth_sub4').value;
        }
        //var forth_sub5 = document.getElementById('forth_sub5').value + "(" + forth_sub5_value + "分)";
        if (Number(forth_sub5_value) != 0) {
            var forth_sub5 = document.getElementById('forth_sub5').value + "(" + forth_sub5_value + "分)";
        }
        else {
            var forth_sub5 = document.getElementById('forth_sub5').value;
        }
        var forth = forth_key + forth_sub1 + forth_sub2 + forth_sub3 + forth_sub4 + forth_sub5;
        var forth_value = Number(forth_sub1_value) + Number(forth_sub2_value) + Number(forth_sub3_value) + Number(forth_sub4_value) + Number(forth_sub5_value);


        var fifth_key = document.getElementById('fifth_key').value;
        var fifth_sub1_value = document.getElementById('fifth_sub1_value').value;
        var fifth_sub2_value = document.getElementById('fifth_sub2_value').value;
        var fifth_sub3_value = document.getElementById('fifth_sub3_value').value;
        var fifth_sub4_value = document.getElementById('fifth_sub4_value').value;
        var fifth_sub5_value = document.getElementById('fifth_sub5_value').value;
        //var fifth_sub1 = document.getElementById('fifth_sub1').value + "(" + fifth_sub1_value + "分)";
        if (Number(fifth_sub1_value) != 0) {
            var fifth_sub1 = document.getElementById('fifth_sub1').value + "(" + fifth_sub1_value + "分)";
        }
        else {
            var fifth_sub1 = document.getElementById('fifth_sub1').value;
        }
        //var fifth_sub2 = document.getElementById('fifth_sub2').value + "(" + fifth_sub2_value + "分)";
        if (Number(fifth_sub2_value) != 0) {
            var fifth_sub2 = document.getElementById('fifth_sub2').value + "(" + fifth_sub2_value + "分)";
        }
        else {
            var fifth_sub2 = document.getElementById('fifth_sub2').value;
        }
        //var fifth_sub3 = document.getElementById('fifth_sub3').value + "(" + fifth_sub3_value + "分)";
        if (Number(fifth_sub3_value) != 0) {
            var fifth_sub3 = document.getElementById('fifth_sub3').value + "(" + fifth_sub3_value + "分)";
        }
        else {
            var fifth_sub3 = document.getElementById('fifth_sub3').value;
        }
        //var fifth_sub4 = document.getElementById('fifth_sub4').value + "(" + fifth_sub4_value + "分)";
        if (Number(fifth_sub4_value) != 0) {
            var fifth_sub4 = document.getElementById('fifth_sub4').value + "(" + fifth_sub4_value + "分)";
        }
        else {
            var fifth_sub4 = document.getElementById('fifth_sub4').value;
        }
        //var fifth_sub5 = document.getElementById('fifth_sub5').value + "(" + fifth_sub5_value + "分)";
        if (Number(fifth_sub5_value) != 0) {
            var fifth_sub5 = document.getElementById('fifth_sub5').value + "(" + fifth_sub5_value + "分)";
        }
        else {
            var fifth_sub5 = document.getElementById('fifth_sub5').value;
        }
        var fifth = fifth_key + fifth_sub1 + fifth_sub2 + fifth_sub3 + fifth_sub4 + fifth_sub5;
        var fifth_value = Number(fifth_sub1_value) + Number(fifth_sub2_value) + Number(fifth_sub3_value) + Number(fifth_sub4_value) + Number(fifth_sub5_value);


        //alert(theme);
        //alert(first_key);
        //alert(first_sub1);
        //alert(first_sub1_value);
        //alert(first_sub2);
        //alert(first_sub2_value);
        //alert(first_sub3);
        //alert(first_sub3_value);
        //alert(first_sub4);
        //alert(first_sub4_value);
        //alert(first_sub5);
        //alert(first_sub5_value);


        //alert(second_key);
        //alert(second_sub1);
        //alert(second_sub1_value);
        //alert(second_sub2);
        //alert(second_sub2_value);
        //alert(second_sub3);
        //alert(second_sub3_value);
        //alert(second_sub4);
        //alert(second_sub4_value);
        //alert(second_sub5);
        //alert(second_sub5_value);


        //alert(third_key);
        //alert(third_sub1);
        //alert(third_sub1_value);
        //alert(third_sub2);
        //alert(third_sub2_value);
        //alert(third_sub3);
        //alert(third_sub3_value);
        //alert(third_sub4);
        //alert(third_sub4_value);
        //alert(third_sub5);
        //alert(third_sub5_value);


        //alert(forth_key);
        //alert(forth_sub1);
        //alert(forth_sub1_value);
        //alert(forth_sub2);
        //alert(forth_sub2_value);
        //alert(forth_sub3);
        //alert(forth_sub3_value);
        //alert(forth_sub4);
        //alert(forth_sub4_value);
        //alert(forth_sub5);
        //alert(forth_sub5_value);


        //alert(fifth_key);
        //alert(fifth_sub1);
        //alert(fifth_sub1_value);
        //alert(fifth_sub2);
        //alert(fifth_sub2_value);
        //alert(fifth_sub3);
        //alert(fifth_sub3_value);
        //alert(fifth_sub4);
        //alert(fifth_sub4_value);
        //alert(fifth_sub5);
        //alert(fifth_sub5_value);
        //alert('获取最大值');
        //var maxid = 0;
        //var successful = false;
        //$.ajax({
        //    type: "post",
        //    contentType: "application/json",
        //    url: "../../Set2Service.asmx/GetMaxID",
        //    data: '{}',
        //    dataType: "json",
        //    async: false,
        //    success: function (result) {
        //        maxid = result.d;
        //    },
        //    error: function (XMLHttpRequest, textStatus, errorThrown) {
        //        alert(XMLHttpRequest.status);
        //        alert(XMLHttpRequest.readyState);
        //        alert(textStatus);
        //    }
        //})

        //public bool addItem(int id, string theme, string firstitem, string firstkeyword, string firstsub1, string firstsub2, string firstsub3, string firstsub4, string firstsub5, string seconditem, string secondkeyword, string secondsub1, string secondsub2, string secondsub3, string secondsub4, string secondsub5,
        //            string thirditem, string thirdkeyword, string thirdsub1, string thirdsub2, string thirdsub3, string thirdsub4, string thirdsub5,
        //                string forthitem, string forthkeyword, string forthsub1, string forthsub2, string forthsub3, string forthsub4, string forthsub5,
        //            string fifthitem, string fifthkeyword, string fifthsub1, string fifthsub2, string fifthsub3, string fifthsub4, string fifthsub5
        //            )
        //修改项目内容
        //alert("修改项目内容");
        //alert(theme);
        $.ajax({
            type: "post",
            contentType: "application/json",
            url: "../../Set2Service.asmx/AlterItem",
            data: '{"id":' + _value + ',"theme":"' + theme + '","firstitem":"' + first + '","firstkeyword":"' + first_key + '","firstsub1":"' + first_sub1 + '","firstsub2":"' + first_sub2 + '","firstsub3":"' + first_sub3 + '","firstsub4":"' + first_sub4 + '","firstsub5":"' + first_sub5 + '",   "seconditem":"' + second + '","secondkeyword":"' + second_key + '","secondsub1":"' + second_sub1 + '","secondsub2":"' + second_sub2 + '","secondsub3":"' + second_sub3 + '","secondsub4":"' + second_sub4 + '","secondsub5":"' + second_sub5 + '",  "thirditem":"' + third + '","thirdkeyword":"' + third_key + '","thirdsub1":"' + third_sub1 + '","thirdsub2":"' + third_sub2 + '","thirdsub3":"' + third_sub3 + '","thirdsub4":"' + third_sub4 + '","thirdsub5":"' + third_sub5 + '",  "forthitem":"' + forth + '","forthkeyword":"' + forth_key + '","forthsub1":"' + forth_sub1 + '","forthsub2":"' + forth_sub2 + '","forthsub3":"' + forth_sub3 + '","forthsub4":"' + forth_sub4 + '","forthsub5":"' + forth_sub5 + '",  "fifthitem":"' + fifth + '","fifthkeyword":"' + fifth_key + '","fifthsub1":"' + fifth_sub1 + '","fifthsub2":"' + fifth_sub2 + '","fifthsub3":"' + fifth_sub3 + '","fifthsub4":"' + fifth_sub4 + '","fifthsub5":"' + fifth_sub5 + '"}',
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

        //addValues(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5,
        //            int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5,
        //            int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5,
        //            int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5,
        //            int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        //修改最大分值
        //alert("修改最大分值");
        $.ajax({
            type: "post",
            contentType: "application/json",
            url: "../../Set2Service.asmx/AlterValue",
            data: '{"id":' + _value + ',"firstvalue":' + first_value + ',"firstsub1":' + first_sub1_value + ',"firstsub2":' + first_sub2_value + ',"firstsub3":' + first_sub3_value + ',"firstsub4":' + first_sub4_value + ',"firstsub5":' + first_sub5_value + ',  "secondvalue":' + second_value + ',"secondsub1":' + second_sub1_value + ',"secondsub2":' + second_sub2_value + ',"secondsub3":' + second_sub3_value + ',"secondsub4":' + second_sub4_value + ',"secondsub5":' + second_sub5_value + ',  "thirdvalue":' + third_value + ',"thirdsub1":' + third_sub1_value + ',"thirdsub2":' + third_sub2_value + ',"thirdsub3":' + third_sub3_value + ',"thirdsub4":' + third_sub4_value + ',"thirdsub5":' + third_sub5_value + ',  "forthvalue":' + forth_value + ',"forthsub1":' + forth_sub1_value + ',"forthsub2":' + forth_sub2_value + ',"forthsub3":' + forth_sub3_value + ',"forthsub4":' + forth_sub4_value + ',"forthsub5":' + forth_sub5_value + ',  "fifthvalue":' + fifth_value + ',"fifthsub1":' + fifth_sub1_value + ',"fifthsub2":' + fifth_sub2_value + ',"fifthsub3":' + fifth_sub3_value + ',"fifthsub4":' + fifth_sub4_value + ',"fifthsub5":' + fifth_sub5_value + '}',
            dataType: "json",
            async: false,
            success: function (result) {
                //alert("请问");
                if (result.d == true) {
                    successful = true;
                    //alert("请问1");
                }
                else {
                    successful = false;
                    //alert("请问2");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                successful = false;
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
            }
        })

        if (successful == false) {
            alert('修改失败');
        }
        else {
            alert("修改成功");
        }
    }

}

//判断分值是否合法
function islegal() {
    var first_sub1_value = document.getElementById('first_sub1_value').value;
    if (!isInteger(first_sub1_value)) {
        return false;
    }
    var first_sub2_value = document.getElementById('first_sub2_value').value;
    if (!isInteger(first_sub2_value)) {
        return false;
    }
    var first_sub3_value = document.getElementById('first_sub3_value').value;
    if (!isInteger(first_sub3_value)) {
        return false;
    }
    var first_sub4_value = document.getElementById('first_sub4_value').value;
    if (!isInteger(first_sub4_value)) {
        return false;
    }
    var first_sub5_value = document.getElementById('first_sub5_value').value;
    if (!isInteger(first_sub5_value)) {
        return false;
    }

    var second_sub1_value = document.getElementById('second_sub1_value').value;
    if (!isInteger(second_sub1_value)) {
        return false;
    }
    var second_sub2_value = document.getElementById('second_sub2_value').value;
    if (!isInteger(second_sub2_value)) {
        return false;
    }
    var second_sub3_value = document.getElementById('second_sub3_value').value;
    if (!isInteger(second_sub3_value)) {
        return false;
    }
    var second_sub4_value = document.getElementById('second_sub4_value').value;
    if (!isInteger(second_sub4_value)) {
        return false;
    }
    var second_sub5_value = document.getElementById('second_sub5_value').value;
    if (!isInteger(second_sub5_value)) {
        return false;
    }


    var third_sub1_value = document.getElementById('third_sub1_value').value;
    if (!isInteger(third_sub1_value)) {
        return false;
    }
    var third_sub2_value = document.getElementById('third_sub2_value').value;
    if (!isInteger(third_sub2_value)) {
        return false;
    }
    var third_sub3_value = document.getElementById('third_sub3_value').value;
    if (!isInteger(third_sub3_value)) {
        return false;
    }
    var third_sub4_value = document.getElementById('third_sub4_value').value;
    if (!isInteger(third_sub4_value)) {
        return false;
    }
    var third_sub5_value = document.getElementById('third_sub5_value').value;
    if (!isInteger(third_sub5_value)) {
        return false;
    }


    var forth_sub1_value = document.getElementById('forth_sub1_value').value;
    if (!isInteger(forth_sub1_value)) {
        return false;
    }
    var forth_sub2_value = document.getElementById('forth_sub2_value').value;
    if (!isInteger(forth_sub2_value)) {
        return false;
    }
    var forth_sub3_value = document.getElementById('forth_sub3_value').value;
    if (!isInteger(forth_sub3_value)) {
        return false;
    }
    var forth_sub4_value = document.getElementById('forth_sub4_value').value;
    if (!isInteger(forth_sub4_value)) {
        return false;
    }
    var forth_sub5_value = document.getElementById('forth_sub5_value').value;
    if (!isInteger(forth_sub5_value)) {
        return false;
    }

    var fifth_sub1_value = document.getElementById('fifth_sub1_value').value;
    if (!isInteger(fifth_sub1_value)) {
        return false;
    }
    var fifth_sub2_value = document.getElementById('fifth_sub2_value').value;
    if (!isInteger(fifth_sub2_value)) {
        return false;
    }
    var fifth_sub3_value = document.getElementById('fifth_sub3_value').value;
    if (!isInteger(fifth_sub3_value)) {
        return false;
    }
    var fifth_sub4_value = document.getElementById('fifth_sub4_value').value;
    if (!isInteger(fifth_sub4_value)) {
        return false;
    }
    var fifth_sub5_value = document.getElementById('fifth_sub5_value').value;
    if (!isInteger(fifth_sub5_value)) {
        return false;
    }
    return true;

}

//判断函数
function isInteger(obj) {
    return (obj % 1 === 0) && (Number(obj) >= 0);
}

//空白项用0填充
function FillwithZero() {
    var first_sub1_value = document.getElementById('first_sub1_value').value;
    if (iswhitespace(first_sub1_value)) {
        document.getElementById('first_sub1_value').value = 0;
    }
    var first_sub2_value = document.getElementById('first_sub2_value').value;
    if (iswhitespace(first_sub2_value)) {
        document.getElementById('first_sub2_value').value = 0;
    }
    var first_sub3_value = document.getElementById('first_sub3_value').value;
    if (iswhitespace(first_sub3_value)) {
        document.getElementById('first_sub3_value').value = 0;
    }
    var first_sub4_value = document.getElementById('first_sub4_value').value;
    if (iswhitespace(first_sub4_value)) {
        document.getElementById('first_sub4_value').value = 0;
    }
    var first_sub5_value = document.getElementById('first_sub5_value').value;
    if (iswhitespace(first_sub5_value)) {
        document.getElementById('first_sub5_value').value = 0;
    }

    var second_sub1_value = document.getElementById('second_sub1_value').value;
    if (iswhitespace(second_sub1_value)) {
        document.getElementById('second_sub1_value').value = 0;
    }

    var second_sub2_value = document.getElementById('second_sub2_value').value;
    if (iswhitespace(second_sub2_value)) {
        document.getElementById('second_sub2_value').value = 0;
    }
    var second_sub3_value = document.getElementById('second_sub3_value').value;
    if (iswhitespace(second_sub3_value)) {
        document.getElementById('second_sub3_value').value = 0;
    }

    var second_sub4_value = document.getElementById('second_sub4_value').value;
    if (iswhitespace(second_sub4_value)) {
        document.getElementById('second_sub4_value').value = 0;
    }

    var second_sub5_value = document.getElementById('second_sub5_value').value;
    if (iswhitespace(second_sub5_value)) {
        document.getElementById('second_sub5_value').value = 0;
    }

    var third_sub1_value = document.getElementById('third_sub1_value').value;
    if (iswhitespace(third_sub1_value)) {
        document.getElementById('third_sub1_value').value = 0;
    }

    var third_sub2_value = document.getElementById('third_sub2_value').value;
    if (iswhitespace(third_sub2_value)) {
        document.getElementById('third_sub2_value').value = 0;
    }

    var third_sub3_value = document.getElementById('third_sub3_value').value;
    if (iswhitespace(third_sub3_value)) {
        document.getElementById('third_sub3_value').value = 0;
    }

    var third_sub4_value = document.getElementById('third_sub4_value').value;
    if (iswhitespace(third_sub4_value)) {
        document.getElementById('third_sub4_value').value = 0;
    }

    var third_sub5_value = document.getElementById('third_sub5_value').value;
    if (iswhitespace(third_sub5_value)) {
        document.getElementById('third_sub5_value').value = 0;
    }


    var forth_sub1_value = document.getElementById('forth_sub1_value').value;
    if (iswhitespace(forth_sub1_value)) {
        document.getElementById('forth_sub1_value').value = 0;
    }

    var forth_sub2_value = document.getElementById('forth_sub2_value').value;
    if (iswhitespace(forth_sub2_value)) {
        document.getElementById('forth_sub2_value').value = 0;
    }

    var forth_sub3_value = document.getElementById('forth_sub3_value').value;
    if (iswhitespace(forth_sub3_value)) {
        document.getElementById('forth_sub3_value').value = 0;
    }

    var forth_sub4_value = document.getElementById('forth_sub4_value').value;
    if (iswhitespace(forth_sub4_value)) {
        document.getElementById('forth_sub4_value').value = 0;
    }

    var forth_sub5_value = document.getElementById('forth_sub5_value').value;
    if (iswhitespace(forth_sub5_value)) {
        document.getElementById('forth_sub5_value').value = 0;
    }


    var fifth_sub1_value = document.getElementById('fifth_sub1_value').value;
    if (iswhitespace(fifth_sub1_value)) {
        document.getElementById('fifth_sub1_value').value = 0;
    }

    var fifth_sub2_value = document.getElementById('fifth_sub2_value').value;
    if (iswhitespace(fifth_sub2_value)) {
        document.getElementById('fifth_sub2_value').value = 0;
    }

    var fifth_sub3_value = document.getElementById('fifth_sub3_value').value;
    if (iswhitespace(fifth_sub3_value)) {
        document.getElementById('fifth_sub3_value').value = 0;
    }

    var fifth_sub4_value = document.getElementById('fifth_sub4_value').value;
    if (iswhitespace(fifth_sub4_value)) {
        document.getElementById('fifth_sub4_value').value = 0;
    }

    var fifth_sub5_value = document.getElementById('fifth_sub5_value').value;
    if (iswhitespace(fifth_sub5_value)) {
        document.getElementById('fifth_sub5_value').value = 0;
    }
}

//判断是否为空白
function iswhitespace(obj) {
    if (obj == "") {
        return true;
    }
    else {
        return false;
    }
}


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
            document.getElementById('theme').innerHTML += result.d;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })
}



//设置启动项时下拉框确定事件
function loadsetstart() {
    //alert("执行");
    
    var myselect = document.getElementById('theme');
    var index = myselect.selectedIndex;
    _value = myselect.options[index].value;
    $.ajax({
        type: "post",
        contentType: "application/json",
        url: "../../Set2Service.asmx/GetMoreInfoById",
        data: '{"id":' + _value + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            var obj = eval("(" + result.d + ")");
            
            document.getElementById('themetext').value = obj.Theme;
            document.getElementById('first_key').value = obj.First_KeyWord;
            document.getElementById('first_sub1').value = obj.First_Sub1;
            document.getElementById('first_sub2').value = obj.First_Sub2;
            document.getElementById('first_sub3').value = obj.First_Sub3;
            document.getElementById('first_sub4').value = obj.First_Sub4;
            document.getElementById('first_sub5').value = obj.First_Sub5;


            document.getElementById('second_key').value = obj.Second_KeyWord;
            document.getElementById('second_sub1').value = obj.Second_Sub1;
            document.getElementById('second_sub2').value = obj.Second_Sub2;
            document.getElementById('second_sub3').value = obj.Second_Sub3;
            document.getElementById('second_sub4').value = obj.Second_Sub4;
            document.getElementById('second_sub5').value = obj.Second_Sub5;
            

            document.getElementById('third_key').value = obj.Third_KeyWord;
            document.getElementById('third_sub1').value = obj.Third_Sub1;
            document.getElementById('third_sub2').value = obj.Third_Sub2;
            document.getElementById('third_sub3').value = obj.Third_Sub3;
            document.getElementById('third_sub4').value = obj.Third_Sub4;
            document.getElementById('third_sub5').value = obj.Third_Sub5;
            

            document.getElementById('forth_key').value = obj.Forth_KeyWord;
            document.getElementById('forth_sub1').value = obj.Forth_Sub1;
            document.getElementById('forth_sub2').value = obj.Forth_Sub2;
            document.getElementById('forth_sub3').value = obj.Forth_Sub3;
            document.getElementById('forth_sub4').value = obj.Forth_Sub4;
            document.getElementById('forth_sub5').value = obj.Forth_Sub5;
            

            document.getElementById('fifth_key').value = obj.Fifth_KeyWord;
            document.getElementById('fifth_sub1').value = obj.Fifth_Sub1;
            document.getElementById('fifth_sub2').value = obj.Fifth_Sub2;
            document.getElementById('fifth_sub3').value = obj.Fifth_Sub3;
            document.getElementById('fifth_sub4').value = obj.Fifth_Sub4;
            document.getElementById('fifth_sub5').value = obj.Fifth_Sub5;
            
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
        url: "../../Set2Service.asmx/GetMoreScoreById",
        data: '{"id":' + _value + '}',
        dataType: "json",
        async: false,
        success: function (result) {
            //alert("索引"+_value);
            //alert("执行加载分数");
            //alert(result.d);
            var obj = eval("(" + result.d + ")");
            document.getElementById('first_sub1_value').value = obj.First_Sub1;
            document.getElementById('first_sub2_value').value = obj.First_Sub2;
            document.getElementById('first_sub3_value').value = obj.First_Sub3;
            document.getElementById('first_sub4_value').value = obj.First_Sub4;
            document.getElementById('first_sub5_value').value = obj.First_Sub5;


            document.getElementById('second_sub1_value').value = obj.Second_Sub1;
            document.getElementById('second_sub2_value').value = obj.Second_Sub2;
            document.getElementById('second_sub3_value').value = obj.Second_Sub3;
            document.getElementById('second_sub4_value').value = obj.Second_Sub4;
            document.getElementById('second_sub5_value').value = obj.Second_Sub5;


            document.getElementById('third_sub1_value').value = obj.Third_Sub1;
            document.getElementById('third_sub2_value').value = obj.Third_Sub2;
            document.getElementById('third_sub3_value').value = obj.Third_Sub3;
            document.getElementById('third_sub4_value').value = obj.Third_Sub4;
            document.getElementById('third_sub5_value').value = obj.Third_Sub5;

            document.getElementById('forth_sub1_value').value = obj.Forth_Sub1;
            document.getElementById('forth_sub2_value').value = obj.Forth_Sub2;
            document.getElementById('forth_sub3_value').value = obj.Forth_Sub3;
            document.getElementById('forth_sub4_value').value = obj.Forth_Sub4;
            document.getElementById('forth_sub5_value').value = obj.Forth_Sub5;

            document.getElementById('fifth_sub1_value').value = obj.Fifth_Sub1;
            document.getElementById('fifth_sub2_value').value = obj.Fifth_Sub2;
            document.getElementById('fifth_sub3_value').value = obj.Fifth_Sub3;
            document.getElementById('fifth_sub4_value').value = obj.Fifth_Sub4;
            document.getElementById('fifth_sub5_value').value = obj.Fifth_Sub5;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest.status);
            alert(XMLHttpRequest.readyState);
            alert(textStatus);
        }
    })

}