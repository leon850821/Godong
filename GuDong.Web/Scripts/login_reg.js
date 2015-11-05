$(function() {
	var $w_h = $(window).height(),
	$t_h = $('#header').height(),
	$b_h = $('#bottom').height();
	$('.login-main .layout').height($w_h - $t_h - $b_h - 80);
	// var $panel = $('.login-panel');
	// var $h = 0 - $panel.height()/2;
	// $panel.css('margin-top',$h);
	// 发现居中挺难看的
	// JS辅助登录框居中，为兼容IE不使用CSS3进行居中
	$('.forget-types .forget-type').hover(function() {
		$(this).addClass('current').siblings('span').removeClass('current');
		showWarn('.input-box','',1);
		$('.forget-form').eq($(this).index()).show(0).siblings('.forget-form').hide(0);
	})
});