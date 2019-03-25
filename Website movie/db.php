<?php header('Content-Type: text/html; charset=utf-8'); ?>

<?php 

$con= mysqli_connect('localhost', 'root', '');
$db =mysqli_select_db($con,'contact');
if ($con){
    
	echo "it is connected";
	}else{
	die('Error.');
	}
if ($db){
    
	echo "Succefully found the database";
	}else{
	die('Error.Database not found');
	}
	?>
<?php header('Content-Type: text/html; charset=utf-8'); ?>



	