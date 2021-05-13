prices = { 1: 150, 2: 250, 3: 628, 4: 50, 5: 17, 6: 69, 7: 136, 8: 420, 9: 350, 10: 76, 11: 60, 12: 23, 13: 115, 14: 271, 15: 215, 16: 688, 17: 90, 18: 18}
images = { 1: "/partimages/ram1.jpg", 2: "/partimages/cpu1.jpg", 3: "/partimages/display1.jpg", 4: "/partimages/harddrive1.jpg", 5: "/partimages/soundcard1.jpg", 6: "/partimages/operatingsystem1.jpg", 7: "/partimages/ram2.jpg", 8: "/partimages/cpu2.jpg", 9: "/partimages/display2.jpg", 10: "/partimages/harddrive2.jpg", 11: "/partimages/soundcard2.jpg", 12: "/partimages/operatingsystem2.jpg", 13: "/partimages/ram3.jpg", 14: "/partimages/cpu3.jpg", 15: "/partimages/display3.jpg", 16: "/partimages/harddrive3.jpg", 17: "/partimages/soundcard3.jpg", 18: "/partimages/operatingsystem3.jpg" }

selectedPrice = {}
selectedPrice = {}
selectedItem = {}


function buynow() {
    var cart = ""
    for (var key in selectedItem) {
        if (selectedItem[key] != null) {
            cart += selectedItem[key] + '/'
        }
    }
    console.log(cart)
    var cookie = readCookie("cart")
    if (cookie != null) {
        cookie = "cart=" + cookie + cart
    }
    else {
        cookie = "cart=" + cart
    }
    document.cookie = cookie;
    return true;
}

$("#ram").on('change', function () {
    selectedItem["ram"] = $(this).val();
    selectedPrice["ram"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["ram"]
    document.getElementById("ramprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("ram_image").src = images[$(this).val()];
    updateTotal()
});

$("#cpu").on('change', function () {
    selectedItem["cpu"] = $(this).val();
    selectedPrice["cpu"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["cpu"]
    document.getElementById("cpuprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("cpu_image").src = images[$(this).val()];
    updateTotal()
});

$("#display").on('change', function () {
    selectedItem["display"] = $(this).val();
    selectedPrice["display"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["display"]
    document.getElementById("displayprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("display_image").src = images[$(this).val()];
    updateTotal()
});

$("#harddrive").on('change', function () {
    selectedItem["harddrive"] = $(this).val();
    selectedPrice["harddrive"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["harddrive"] 
    document.getElementById("harddriveprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("harddrive_image").src = images[$(this).val()];
    updateTotal()
});

$("#soundcard").on('change', function () {
    selectedItem["soundcard"] = $(this).val();
    selectedPrice["soundcard"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["soundcard"]
    document.getElementById("soundcardprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("soundcard_image").src = images[$(this).val()];
    updateTotal()
});

$("#os").on('change', function () {
    selectedItem["os"] = $(this).val();
    selectedPrice["os"] = parseFloat(prices[$(this).val()] || 0);
    var price = selectedPrice["os"]
    document.getElementById("osprice").innerHTML = "$" + price.toFixed(2);
    document.getElementById("os_image").src = images[$(this).val()];
    updateTotal()
});

function updateTotal() {
    var total = parseFloat(selectedPrice["cpu"]||0.00) + parseFloat(selectedPrice["ram"]||0.00) + parseFloat(selectedPrice["display"]||0.00)
        + parseFloat(selectedPrice["harddrive"]||0.00) + parseFloat(selectedPrice["soundcard"]||0.00) + parseFloat(selectedPrice["os"]||0.00);
    document.getElementById("totalprice").innerHTML = "$" + total.toFixed(2);
    console.log(selectedPrice);
    console.log(prices);
}


function initStore() {
    storePrices()
    setSelectedItem()
    $('#ram').trigger("change");
    $('#cpu').trigger("change");
    $('#display').trigger("change");
    $('#harddrive').trigger("change");
    $('#soundcard').trigger("change");
    $('#os').trigger("change");
    
}

function setSelectedItem() {
    $('#ram').val(readCookie("picked_ram"));
    $('#cpu').val(readCookie("picked_cpu"));
    $('#display').val(readCookie("picked_display"));
    $('#harddrive').val(readCookie("picked_harddrive"));
    $('#soundcard').val(readCookie("picked_soundcard"));
    $('#os').val(readCookie("picked_os"));

    // re-initialize material-select
    $('#myselect').material_select();
}

initStore()