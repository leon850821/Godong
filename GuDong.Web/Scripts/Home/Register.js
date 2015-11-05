$(function () {
    // 发送验证码
    $('.abs-vcode a').click(function () {
        if (checkPhone($('.user-phone'))) {
            var index = layer.load(0, { shade: [0.5, '#C0C0C0'] });
            $.get("/CodeRecord/SendRegisterSmsCode", { TelNo: $('.user-phone').val(), temp: (new Date()).valueOf() }, function (result) {
                layer.close(index);
                layer.msg(result);
            });
        }
    });
});