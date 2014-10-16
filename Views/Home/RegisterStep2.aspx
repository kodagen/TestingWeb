<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="content-type" content="text/html; charset=UTF-8" />
	<title>Smart-HD</title>
	<link href="/Content/css/style.css" rel="stylesheet" type="text/css" />
	<link rel="shortcut icon" href="images/favicon.png" type="image/png" />
    <script type="text/javascript" src="/Content/jquery-2.1.1.js"></script>
	<script type="text/javascript">
	    function ConfirmForms() {
	        if (document.forms[0].password2.value != document.forms[0].password1.value) {
	            alert("Пароли не совпадают");
	            return;
	        }
            var host = window.location.host;
            $.ajax({
                url: "http://" + host + "/Home/CreateAccount/",
                type: 'post',
       //         dataType: 'json',
                cache: false,
                data: {
                    "password": document.forms[0].password1.value,
                    "city": document.forms[1].city.value,
                    "zip": document.forms[1].zip.value,
                    "country": document.forms[1].country.value,
                   "promocode": document.forms[2].promocode.value
                     },
                async: false,
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                success: function (data) {
                    alert(data);
                },
                error: function (xhr, textStatus, errorThrown) {
                    alert("ERROR GETING DATA: " + textStatus);
                }
            });
        }
    </script>

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
			<div class="step float_l" style="margin: 0 0 0 20px;">2</div>
			<span class="float_l">Завершение регистрации на Smart-HD</span>
		</div>
		
		<div class="register">
			<div class="form">
				<form enctype="multipart/form-data">
					<span>kdfk@ukr.net</span>
					<p>Данный E-mail будет использоваться для авторизации.</p>
					<br/>
					<span>Пароль:</span>
					<input class="field" type="password" name="password1" />
					<p>Введите пароль для защиты вашего аккаунта.</p>
					<br/>
					<span>Подтвердите пароль:</span>
					<input class="field" type="password" name="password2" />
					<p>Подтввердите ваш пароль.</p>
				</form>
			</div>
		</div>
		
		<br/>
		<div class="register">
			<div class="form">
				<form enctype="multipart/form-data">
					<span>Адрес:</span>
					<input class="field" type="text" />
					<p>Укажите ваш действительный адрес.</p>
					<br/>
					<span>Город:</span>
					<input class="field" type="text" name="city" />
					<p>Город в котором вы проживаете.</p>
					<br/>
					<span>Почтовый индекс:</span>
					<input class="field" type="text" name="zip" />
					<p>Ваш почтовый индекс.</p>
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
				</form>
			</div>
		</div>
		<br/>
		
		<div class="register">
			<div class="form without">
				<form enctype="multipart/form-data">
					<span>Промо-код:</span>
					<input required class="field" type="text" name="promocode" />
					<p>Заполните данное поле, если у вас есть промо-код.</p>
				</form>
			</div>
		</div>
		<br/>
		<br/>
		<div class="register">
			<div class="form without">
				<form>
					<input class="orange_button" type="button" value="Создать аккаунт" onclick="ConfirmForms()" />
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