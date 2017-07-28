/*
 * File:        jquery.input.js
 * Version:     1.0.0
 * Author:      zhangdeng(RandyField)
 * 
 * rely on:
 *          jquery-1.10.2.min.js 
 *           art-dialog.js version 7.0.0 
 *
 * Copyright 2017-2018 RandyField, all rights reserved.
 *
 */
$.extend({
    returnBack: function (url) {
        parent.document.getElementById("rightMain").src = url;
    },

    inputValiNull: function ($e, tipsTitle, tipsContent) {
        var isNull = false;
        $e.each(function () {
            if ($(this).val() == "") {
                isNull = true;
                layer.msg(tipsContent, {
                    time: 3000
                });
            }
        });
        return isNull;
    },

    inputIsNull: function ($e, tipsTitle, tipsContent) {
        var isNull = false;
        $e.each(function () {
            if ($(this).val() == "") {
                isNull = true;
                var d = dialog({
                    fixed: true,
                    title: tipsTitle,
                    content: tipsContent
                });
                d.showModal();
            }
        });
        return isNull;
    },

    saveTips: function (tipsTitle, tipsContent, isSuccess) {
        var d = dialog({
            fixed: true,
            title: tipsTitle,
            content: tipsContent,
            ok: function () {
                this.remove();
            }
        });
        d.addEventListener('close', function () {
            this.remove();
        });

        d.showModal();
    },

    tips: function (tipsContent, isSuccess, url) {
        //layer.confirm('保存成功', { icon: 1, title: '提示' }, function (index) {
        //    //do something  
        //    //alert("确认");
        //    layer.close(index);
        //});
        if (isSuccess) {
            layer.alert(tipsContent, {
                icon: 6
            }, function (index) {
                parent.document.getElementById("rightMain").src = url;
            });
        }

            //"../Permission/Index"
        else {
            layer.alert(tipsContent, {
                icon: 5
            });
        }



        //layer.msg('操作成功!',
        //    {
        //        icon: 6
        //    });
        //layer.open({
        //    type: 0,
        //    title: tipsTitle,//不显示标题栏
        //    closeBtn: false,
        //    area: '300px;',
        //    shade: 0.8,
        //    resize: false,
        //    btn: ['确定'],
        //    btnAlign: 'c',
        //    moveType: 1, //拖拽模式，0或者1 
        //    content: '<i class="layui-icon">' + tipsContent + '</i>'
        //});
    }
});
