
$(function () {
    $('.edit-mode').hide();
    $('div#TCKNh6').hide();
    $('.edit-user, .cancel-user').on('click', function () {
        var tr = $(this).parents('tr:first');
        tr.find('.edit-mode, .display-mode').toggle();
    });

    $('.save-user').on('click', function () {
        var tr = $(this).parents('tr:first');
        var TCKN = tr.find("#TCKN").val();
        var AdSoyad = tr.find("#AdSoyad").val();
        var Sifre = tr.find("#Sifre").val();
        var Fiyat = tr.find("#Fiyat").val();
        var paraBirimi = tr.find("#paraBirimi").val();
        var tlFiyat = tr.find("#tlFiyat").val();
        var Id = tr.find("#UserID").html();
        tr.find("#lblTCKN").text(TCKN);
        tr.find("#lblAdSoyad").text(AdSoyad);
        tr.find("#lblSifre").text(Sifre);
        tr.find("#lblFiyat").text(Fiyat);
        if (paraBirimi == 1) {
            tr.find("#lblparaBirimi").text("Euro");
            tr.find("#lbltlFiyat").text(Fiyat*7);

        } else {
            tr.find("#lblparaBirimi").text("Dolar");
            tr.find("#lbltlFiyat").text(Fiyat * 6);

        }
        tr.find('.edit-mode, .display-mode').toggle();


        $.ajax({
            method: "POST",
            url: "/Home/Update/",
            data: {
                "Id": Id,
                "TCKN": TCKN,
                "AdSoyad": AdSoyad,
                "Sifre": Sifre,
                "Fiyat": Fiyat,
                "paraBirimi": paraBirimi
            }
        }).done(function (data) {
            if (data.result) {

                alert("Düzenleme Başarılı");

            }
            else {
                alert("Düzenleme Başarısız");
            }

        }).fail(function () {
            alert("sunucu ile bağlantı sağlanamadı");
        });

    });
})
