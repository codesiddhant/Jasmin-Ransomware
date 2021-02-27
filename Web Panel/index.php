<?php

session_start();
if( isset($_SESSION['username']) ){
	header("Location: dashboard.php");
}
?>

<!DOCTYPE html>
<html lang="en" >
<head>
   <meta charset="UTF-8" http-equiv="refresh" content="3;url=login.php" />
  <title>Jasmin Dashboard</title>
  <link rel="stylesheet" href="./assets/css/loading.css">
</head>
<body>
<div class="wrap">
  <div class="bg">
    <div class="loading">
      <span class="title">loading.....</span>
      <span class="text"> Jasmin Dashboard</span>
    </div>
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

</body>
</html>