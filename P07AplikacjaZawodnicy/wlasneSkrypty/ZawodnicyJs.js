
$(document).ready(function () {

    
        $.ajax({
            method: "POST",
            url: "ZawodnicySerwis.aspx",
            //data: { liczba1Parametr: liczba1, liczba2Parametr: liczba2 }
        }) 
            .done(function (msg) {
             //   alert("Data Saved: " + msg);
                $("#dvTabelaZawodnicy").html(msg);
            });


    //now-ui-icons ui-1_zoom-bold
    $("#btnLupka").click(function () {

        var kraj = $("#txtKraj").val();
        $.ajax({
            method: "POST",
            url: "ZawodnicySerwis.aspx",
            data: { kraj: kraj }
        })
            .done(function (msg) {
                //   alert("Data Saved: " + msg);
                $("#dvTabelaZawodnicy").html(msg);
            });


    });

});