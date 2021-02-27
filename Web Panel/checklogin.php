<?php
session_start();
include("database/db_conection.php");

if(isset($_POST['username']))
{
    $username=$_POST['username'];
    $password=$_POST['password'];

    $check_user="select * from master WHERE admin='$username'AND creds='$password'";

    $run=mysqli_query($dbcon,$check_user);

    if(mysqli_num_rows($run))
    {
         echo "success";

        $_SESSION['username']=$username;//here session is used and value of $user_email store in $_SESSION.

    }
    
	
}

else {echo "not allowed";}

?>