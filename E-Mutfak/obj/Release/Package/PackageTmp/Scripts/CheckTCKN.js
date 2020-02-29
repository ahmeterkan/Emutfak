$("document").ready(function () {

    var checkTcNum = function (value) {
        value = value.toString();
        var isEleven = /^[0-9]{11}$/.test(value);
        var totalX = 0;
        for (var i = 0; i < 10; i++) {
            totalX += Number(value.substr(i, 1));
        }
        var isRuleX = totalX % 10 == value.substr(10, 1);
        var totalY1 = 0;
        var totalY2 = 0;
        for (var i = 0; i < 10; i += 2) {
            totalY1 += Number(value.substr(i, 1));
        }
        for (var i = 1; i < 10; i += 2) {
            totalY2 += Number(value.substr(i, 1));
        }
        var isRuleY = ((totalY1 * 7) - totalY2) % 10 == value.substr(9, 0);
        return isEleven && isRuleX && isRuleY;
    };


    $('#TCKN').on('keyup focus blur load', function (event) {
        event.preventDefault();
        var isValid = checkTcNum($(this).val());
        console.log('isValid ', isValid);
        if (isValid) {
            $('h6').text("TRUE").attr('class', 'text-uppercase text-success');
        }
        else {
            $('h6').text("FALSE").attr('class', 'text-uppercase text-danger');
        }
    });
});