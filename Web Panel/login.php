<?php

session_start();
if( isset($_SESSION['username']) ){
	header("Location: ./assets/other/loading.php");
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Login Below</title>
    <!--<link rel="stylesheet" type="text/css" href="assets/css/style.css">-->
    <link rel="stylesheet" type="text/css" href="assets/css/customstyle.css">
    <link href='http://fonts.googleapis.com/css?family=Comfortaa' rel='stylesheet' type='text/css'>
	<link rel="stylesheet" href="./assets/css/style.css">
</head>
<body>


<div class="background-wrap">
  <div class="background"></div>
</div>

<form id="accesspanel" action="checklogin.php" method="post">
  <h1 id="litheader">LOGIN</h1>
  <div class="inset">
    <p>
      <input type="text" name="username" id="email" placeholder="Email address">
    </p>
    <p>
      <input type="password" name="password" id="password" placeholder="Access code">
    </p>
    <div style="text-align: center;">
      <div class="checkboxouter">
        <input type="checkbox" name="rememberme" id="remember" value="Remember">
        <label class="checkbox"></label>
      </div>
      <label for="remember">Remember me for 14 days</label>
    </div>
    <input class="loginLoginValue" type="hidden" name="service" value="login" />
  </div>
  <p class="p-container">
    <input type="submit" name="Login" id="go" value="Authorize">
  </p>
</form>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
<script src="assets/js/login.js?version=20190430v01"></script>
</body>
</html>