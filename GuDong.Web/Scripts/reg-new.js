// 显示提示
var showWarn = function (ele, msg, hide) {
    var box = $(ele).parents('li').find('.input-tips');
    $(ele).addClass('warn-box')
    if (hide) {
        $(ele).removeClass('warn-box');
        box.css('visibility', 'hidden');
    }
    else {
        box.css('visibility', 'visible').text(msg);
    }
}
// 显示提示 end
$(function () {
    // 验证
    // 用户名
    $('.user-name').blur(function () {
        if (!checkAccount(this)) {
            showWarn(this, '用户名为数字、字母与下划线组合，长度6-25位');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 密码
    $('.user-password').blur(function () {
        if (!checkPwd(this)) {
            showWarn(this, '密码长度6-20位，区分大小写');
        }
        else {
            showWarn(this, '', 1);
            if ($('.user-cfm-password').val()) {
             $('.user-cfm-password').blur();
            }
        }
    });
    // 确认密码
    $('.user-cfm-password').blur(function () {
        if (!checkConfirmPwd(this)) {
            showWarn(this, '两次输入的密码不一致');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 手机号码
    $('.user-phone').blur(function () {
        if (!checkPhone(this)) {
            showWarn(this, '请输入正确的手机号码');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 发送验证码
    $('.abs-vcode a').click(function() {
        $('.user-phone').blur();
    });
    // 手机验证码
    $('.user-phone-code').blur(function () {
        if (!checkSmscode(this)) {
            showWarn(this, '请输入正确的手机验证码');
        }
        else {
            showWarn(this, '', 1);
        }
    });    
    // 邮箱地址
    $('.user-mail').blur(function () {
        if (!checkEmail(this)) {
            showWarn(this, '请输入正确的邮箱地址');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 身份证
    $('.reg-new-idcode').blur(function () {
        if (!checkIdcode(this)) {
            showWarn(this, '请输入正确的身份证号码');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 姓名
    $('.user-real-name').blur(function () {
        if (!checkName(this)) {
            showWarn(this, '请输入您的真实姓名');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 推荐码	
    $('.user-recommandcode').blur(function () {
        if (!checkInvitecode(this)) {
            showWarn(this, '请输入正确的推荐码，推荐码由数字组成');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 验证码
    $('.user-vcode').keyup(function() {
        if($(this).val().length == 4) {
            if (!checkVcode(this)) {
               showWarn(this, '请输入正确的验证码');
            }
            else {
                $(this).keydown(function(e) {
                 var ev = document.all ? window.event : e;
                  if (ev.keyCode == 13) {
                      $('.input-submit-btn').click();
                  }
                 })
                showWarn(this, '', 1);
            }
        }
        else {
            showWarn(this, '请输入正确的验证码');
        }        
    });
    // $('.user-vcode').blur(function () {
    //     if (!checkVcode(this)) {
    //         showWarn(this, '请输入正确的验证码');
    //     }
    //     else {
    //         $(this).keydown(function(e) {
    //             var ev = document.all ? window.event : e;
    //              if (ev.keyCode == 13) {
    //                  $('.input-submit-btn').click();
    //              }
    //         })
    //         showWarn(this, '', 1);
    //     }
    // });
    // 注册协议
    $('.agreement-check').change(function () {
        if (!checkAgree(this)) {
            showWarn(this, '请阅读并勾选《古德金融集团注册协议》');
        }
        else {
            showWarn(this, '', 1);
        }
    });
    // 登录检测
    $('.login-btn').click(function () {
        $('.input-box').blur();
        if ($('.warn-box').length) {
            return false;
        }
        else {
            $("form").submit();
            // 表单id请修改
            return true;
        }
    });    
    // 入驻检测
    $('.mall-apply-btn').click(function () {
        $('.input-box').blur();
        if ($('.warn-box').length) {
            return false;
        }
        else {
            $("form").submit();
            // 表单id请修改
            return true;
        }
    });        
    // 手机找回检测
    $('.forget-btn').click(function () {
        $('.input-items:visible .input-box').blur();
        if ($('.warn-box').length) {
            return false;
        }
        else {
            $(this).parents('form').submit();
            // 表单id请修改
            return true;
        }
    });
    // 注册检测
    $('.register-btn').click(function () {
        $('.input-box').blur();
        if (!checkAgree($('.agreement-check'))) {
            showWarn($('.agreement-check'), '请阅读并勾选《古德金融集团注册协议》');
            return false;
        }
        else if ($('.warn-box').length) {
            return false;
        }
        else {        
            $("form").submit();
            // 表单id请修改
            return true;
        }
    });
})
