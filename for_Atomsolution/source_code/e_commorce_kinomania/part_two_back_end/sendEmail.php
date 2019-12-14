<?php

	require_once("php_mail/PHPMailerAutoload.php");
	require_once("php_mailerInstal/src/PHPMailer.php");
	require_once("php_mailerInstal/src/Exception.php");
	ob_start();	
	
	/*
		
Здравейте ! поради причината че не открих тема в която да се споменава как да си нагласим настройките за да ползваме пощата на mail.bg реших да ги постна тук за хората който като мен ползват тази поща.
		
		За да използвате пощенски клиент трябва да направите следните настройки:
		
		Потребител: Напишете целия си адрес вкл. @mail.bg
		
		За POP3:
		
		Протокол: POP3
		
		Входящ сървър: pop3.mail.bg
		
		Порт: оставете този по подразбиране или 110
		
		За IMAP:
		
		Протокол: IMAP
		
		Входящ сървър: imap.mail.bg
		
		Порт: оставете този по подразбиране или 143
		
		Изходящ сървър: smtp.mail.bg
		
		Порт: 25 или за клиенти на Виваком - 2525
		
		Включете опцията "server requires authentication" и/или попълнете отново целия си адрес за потребител и въведете отново паролата.
		
		За да можете и да изпращате трябва да активирате услугата "SMTP за mail клиент или мобилен телефон" от меню "екстри" намиращо се до "изход" в уеб пощата. Няма да можете да изпращате писма, ако не го направите.
		
		Надявам се да съм помогнал.
	
	*/
	
	
		if(isset($_POST['senTheEmail'])){
			
			  $userNameIs= $_POST['userName'];
			  $userEmailIs = $_POST['userEmail'];
			  $mailSubject = $_POST['mailSubject'];
			  $myEmail="asen_lozanovp@mail.bg";
			  
			  
			  
		      $mail = new PHPMailer(true);	 
			  
			  try{
				  
			 
			  $mail->SMTPDebug = 2;
		      $mail->isSMTP(); 
			  $mail->SMTPAuth = true;	
			  $mail->SMTPSecure= 'ssl';
			  $mail->Host ='smtp.mail.bg';	
			  $mail->Port = 465;
			  $mail->isHTML();
			  $mail->Username = 'asen_lozanovp@mail.bg';
			  $mail->Password ='calistra';	
			  $mail->setFrom('asen_lozanovp@mail.bg');
			  $mail->Subject = 'Here is the user Email  '.$userEmailIs;
			  $mail->Body= $mailSubject."  From..".$userNameIs;
			  $mail->AddAddress('asen_lozanovp@mail.bg'); // here

			  
			 
				$mail->send();
				header("Location:index.php");
				//echo "success";
				
		      } catch (Exception $e) {
    				echo 'Message could not be sent. Mailer Error: ', $mail->ErrorInfo;
			  }
					
				//header("Location:index.php");
		}


?>