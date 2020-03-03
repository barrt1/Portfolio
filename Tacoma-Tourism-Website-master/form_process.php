<?php



print_r($_POST);

$name_error = $email_error = $phone_error = $url_error ="";
$name = $email = $phone = $phone = $url ="";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
	if (empty($_POST["name"])) {
		$name_error = "Name is required";
	} else {
		$name = test_input($_POST["name"]);
		// check if name only contains letters and white space
		if(!preg_match("/^[a-zA-Z]*$/",$name)) {
			$name_error = "Only letters and white space are allowed";
		}
	}
	
	if (empty($_POST["email"])) {
		$email_error = "Email is required";
	} else {
		$email = test_input($_POST["email"]);
		// check if email address is formatted correctly
		if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
			$email_error = "Invalid email format";
		}
	}
	
	if (empty($_POST["phone"])) {
		$phone_error = "Phone number required";
	} else {
		$phone = test_input($_POST["phone"]);
		// check if phone is valid
		if (!preg_match("/^(\d[\s-]?)?[\(\[\s-]{0,2}?\d{3}[\)\]\s-]{0,2}?\d{3}[\s-]?\d{4}$/i", $phone)) { $phone_error = "Invalid phone number";
		}
	}
	
	if (empty($_POST["url"])) {
		$url_error = "";
	} else {
		$url = test_input($_POST["url"]);
		// check if URL address syntax is valid (this regular expression also allows dashes in the URL)
		if (!preg_match("/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i",$url)) {
			$url_error = "Invalid URL";
		}
	}
	if (empty($_POST["message"])) {
		$message = "";
	} else {
		$message = test_input($POST["message"]);
	}
}

function test_input($data) {
	$data = trim($data);
	$data = stripslashes($data);
	$data = htmlspecialchars($data);
	return $data;
}


