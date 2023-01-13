function sendData(zifra) {
    $.ajax({
        url: "/Casino",
        data: {"value" : zifra},
        type: "POST",
        error: function () {
            alert('bebra')
        }
    });
}