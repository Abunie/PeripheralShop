
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