<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width">
    <meta name="description" content="Affordable and professional web design">
	  <meta name="keywords" content="web design, affordable web design, professional web design">
  	<meta name="author" content="Daniel Andrei">
    <title>Pardoseli industriale elicopterizate</title>
    <link rel="stylesheet" href="./css/style.css">
	  </head>
<body>
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

<?php
if(isset($_POST['submit']))
{
$fname = $_POST['Nume'];
$numar = $_POST['Numar'];
$email = $_POST['Email'];
$mesaj = $_POST['Mesaj'];

}


$sql = "INSERT INTO info (nume, email, mesaj, numardetelefon)
VALUES ('$fname', '$email', '$mesaj', '$numar')";

if ($con->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $con->error;
}



?> 


</body>
</html>