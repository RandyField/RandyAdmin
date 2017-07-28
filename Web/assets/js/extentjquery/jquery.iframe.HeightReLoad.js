/*
 * File:        jquery.iframe.HeightReLoad.js
 * Version:     1.0.0
 * Author:      zhangdeng(RandyField)
 * 
 * Copyright 2017-2018 RandyField, all rights reserved.
 *
 */

$.extend({
    ReloadIframe: function(ElementId) {
        var userAgent = navigator.userAgent;
        var iframe = parent.document.getElementById(ElementId);
        var subdoc = iframe.contentDocument || iframe.contentWindow.document;
        var subbody = subdoc.body;
        var realHeight;
        //谷歌浏览器特殊处理
        if (userAgent.indexOf("Chrome") > -1) {
            realHeight = subdoc.documentElement.scrollHeight;
        }
        else {
            realHeight = subbody.scrollHeight;
        }
        $(iframe).height(realHeight);
    }
});

//$.extend({
//    ReloadIframe: function initIframeHeight(ElementId) {
//        debugger;
//        var userAgent = navigator.userAgent;
//        var iframe = parent.document.getElementById(ElementId);
//        var subdoc = iframe.contentDocument || iframe.contentWindow.document;
//        var subbody = subdoc.body;
//        var realHeight;
//        //谷歌浏览器特殊处理
//        if (userAgent.indexOf("Chrome") > -1) {
//            realHeight = subdoc.documentElement.scrollHeight;
//        }
//        else {
//            realHeight = subbody.scrollHeight;
//        }
//        $(iframe).height(realHeight);
//    }()
//});

//jQuery.extend({
//    min: function (a, b) { return a < b ? a : b; },
//    max: function (a, b) { return a > b ? a : b; }
//});