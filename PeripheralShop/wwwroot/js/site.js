// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.tabs').tabs();
});

$(document).ready(function () {
    $('select').material_select();
});

function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function addCart(id) {
    var cookie = readCookie("cart")
    if (cookie != null) {
        cookie = "cart=" + cookie + id + "/"
    }
    else {
        cookie = "cart=" + id + "/"
    }
    document.cookie = cookie;
}