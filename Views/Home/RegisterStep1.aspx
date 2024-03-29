﻿<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="content-type" content="text/html; charset=UTF-8">
	<title>Smart-HD</title>
	<link href="/Content/css/style.css" rel="stylesheet" type="text/css" />   	
	<link rel="shortcut icon" href="images/favicon.png" type="image/png" />
	

</head>

<body>
	
	<div class="top_line">
		<div class="centred">
			<a class="logo" href="index.aspx"></a>
			<a class="fb" target="_blank" href="http://facebook.com"></a>
			<ul>
				<li class="ru"><a href="#">Русский</a></li>
				<li class="en" href="#"><a href="#">English</a></li>
			</ul>
		</div>
	</div>
	<div class="centred">
		<div class="steps">
			<div class="step float_l" style="margin: 0 0 0 70px;">1</div>
			<span class="float_l">Регистрация на Smart-HD</span>
			<div class="step float_r" style="margin: 0 70px 0 0;">2</div>
		</div>
		
		<div class="register">
			<div class="form">
				<form action="/Home/RegisterStep2" method=post enctype="multipart/form-data" >
					<span>E-mail:</span>
					<input class="field" type="text" name="email" />
					<p>На вашу электронную почту будет  выслана ссылка для подтверждения регистрации.</p>
					<br/>
					<span>Имя и Фамилия:</span>
					<input class="field" type="text" name="name" />
					<p>Введите пожалуйста ваше действительное Имя и Фамилию.</p>
					<br/>
					<span>Телефон:</span>
					<input class="field" type="text" name="telephon" />
					<p>Укажите ваш действующий номер телефона.</p>
					<br/>
					<span>Страна:</span>
					<div class="select">
						<select name="country">
							<option>---</option>
							<option>Israel</option>
							<option>Ukraine</option>
							<option>USA</option>
						</select>
					</div>
					<p>Выберите страну в которой вы проживаете.</p>
					<br/>
					<br/>
                    <input class="orange_button" type="submit" value="Продолжить регистрацию" />
				<!--	<input class="orange_button" type="button" value="Продолжить регистрацию" onclick="location.href='/Home/RegisterStep2'" /> -->
				</form>
			</div>
		</div>
		
		
		
		
	</div>
	<div class="clear"></div>
	
	<div class="footer">
		<p class="copyright">Smart-HD © 2014 Все права защищены.</p>
	</div>
	
	
</body>
</html>