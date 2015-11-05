$(function(){ 
		var _wrap=$('.annouces-list ul');//定义滚动区域 
		var _interval=2000;//定义滚动间隙时间 
		var _moving;//需要清除的动画 
		_wrap.hover(function(){ 
		clearInterval(_moving);//当鼠标在滚动区域中时,停止滚动 
		},function(){ 
		_moving=setInterval(function(){ 
		var _field=_wrap.find('li:first');//此变量不可放置于函数起始处,li:first取值是变化的 
		var _h=_field.height();//取得每次滚动高度 
		_field.animate({marginTop:-_h+'px'},600,function(){//通过取负margin值,隐藏第一行 
		_field.css('marginTop',0).appendTo(_wrap);//隐藏后,将该行的margin值置零,并插入到最后,实现无缝滚动 
		}) 
		},_interval)//滚动间隔时间取决于_interval 
		}).trigger('mouseleave');//函数载入时,模拟执行mouseleave,即自动滚动 
}); 
// 文字滚动 end
$(function() {
// banner滚动
// 图片滚动
	var myslider = function(slider,ctrler,area) {
		var sliders = slider , ctrl = ctrler.find('span'), a = area ,
		items = sliders.length - 1, j = 1 , auto = true ;
				
		var switcher = function(i) {
			ctrl.eq(i).addClass('current').siblings().removeClass('current').find('i').show();
			sliders.eq(i).stop(true,true).fadeIn(600).siblings().stop(true,false).fadeOut(600);
		}		
		var slideindex = function(j,k) {
			switcher(j);
			i = j + 1;
			i = j < k?i:0;	
			return i;
		}
		ctrl.each(function(index) {
			$(this).mouseover(function() {
				switcher(index);
				if($(this).find('i'))
				{
					$(this).find('i').stop(true,true).fadeIn(0);
				}
			});
		});	
		var autoslide = setInterval(function() {			
			j = slideindex(j,items);
		},3000);

		a.hover(function() {
			clearInterval(autoslide);	
		},
		function() {
			clearInterval(autoslide);
			j = ctrler.find('.current').index() + 1;			
			j = j <= items?j:0;							
			j = slideindex(j,items);
			autoslide = setInterval(function() {						
			j = slideindex(j,items);
		},3000);
		});
	}

	// 图片滚动 end
// banner 滑动调用	
	myslider($('.banner-in a'),$(".banner-ctrler"),$(".banner"));
// banner 滑动调用 end
});
$(function() {
	$('.tit-tabs li').hover(function() {
		$(this).addClass('current').siblings('li').removeClass('current');
		$('.c-lists ul').stop(true,true).eq($(this).index()).fadeIn(300).siblings('ul').fadeOut(300);
	});
})