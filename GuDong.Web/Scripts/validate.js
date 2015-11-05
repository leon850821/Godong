// 用户名

function checkAccount(e){
	var inputVal = $.trim($(e).val());
	var pattern=/^[A-Za-z0-9\_]{6,20}$/;
	if(!inputVal) {
		return false;
	}	
	else if(pattern.test(inputVal)) {			
		return true;
	}		
	else {	
		return false;
	}
}	
// 密码

function checkPwd(e){
	var inputVal = $.trim($(e).val());
	var pattern=/^.{6,20}$/;
	if(!inputVal) {
		return false;
	}
	else if(pattern.test(inputVal)) {	
		return true;
	}		
	else {		
		return false;
	}
}

// 确认密码

function checkConfirmPwd(e){
	var pwd = $.trim($(".user-password").val());
	var inputVal = $.trim($(e).val());	 
	if(inputVal != pwd || !inputVal) {
		return false;
	}	
	else {	
		return true;
	}
}	

// 手机号码

function checkPhone(e){
	var inputVal = $.trim($(e).val());
	var pattern=/^1[3|4|5|7|8][0-9]\d{8}$/;
	if(!inputVal) {
		return false;
	}	
	else if(pattern.test(inputVal)) {		
		return true;
	}		
	else {
		return false;
	}
}	

// 验证码

function checkSmscode(e){
	var inputVal = $.trim($(e).val());
	if(!inputVal) {
		return false;
	}
	if(inputVal.length != 6 || isNaN(inputVal)) {
		return false;
	}
	else {
		return true;
	}
}	
// 邮箱地址
function checkEmail(e){
	var inputVal = $.trim($(e).val());
	var pattern=/^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
	if(!inputVal) {		
		return false;
	}	
	else if(pattern.test(inputVal)) {				
		return true;
	}		
	else {		
		return false;
	}
}	
// 邮箱地址 end
// 身份证

function checkIdcode(e){
	var inputVal = $.trim($(e).val());	
	var pattern = /^[1-9](\d{16}|\d{13})[0-9xX]$/;
	if(!pattern.test(inputVal)) {
		return false;
	}
	else {
		return true;
	}
}	
// 姓名

function checkName(e){
	var inputVal = $.trim($(e).val());	
	var pattern = /^([\u4E00-\u9FA5]+,?)+$/;
	if(!pattern.test(inputVal)) {
		return false;
	}
	else {
		return true;
	}
}	

// 推荐码

function checkInvitecode(e){
	var inputVal = $.trim($(e).val());
	if(inputVal&&isNaN(inputVal)) {
		return false;
	}
	else {
		return true;
	}
}	

// 验证码

function checkVcode(e){
	var inputVal = $.trim($(e).val());
	if(!inputVal) {
		return false;
	}
	if(inputVal&&inputVal.length != 4) {
		return false;
	}
	else {
		return true;
	}
}	

// 注册协议
function checkAgree(e){
	if(!$(e).attr('checked')) {		
		return false;
	}
	else {
		return true;
	}
}