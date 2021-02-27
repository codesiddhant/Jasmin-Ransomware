<?php
session_start();
if(!isset($_SESSION['username']) ){
	header("Location: login.php");
}
$file=$_GET['file'];
if(!empty($file)){
    // Define headers
    header("Cache-Control: public");
    header("Content-Description: File Transfer");
    header("Content-Disposition: attachment; filename=$file");
    header("Content-Type: text/encoded");
    header("Content-Transfer-Encoding: binary");
    
    // Read the file
   readfile($file);
    exit;
}else{
    echo 'The file does not exist.';
}
?>