
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>
<body>
    
</body>
</html>
<?php
session_start();
$connection = mysqli_connect("localhost","root","","crud" );
if(isset($_POST['insert_btn']))
{
    $Tanc = $_POST['Tanc'];
    $Milyen = $_POST['Milyen'];
    $Honnan  = $_POST['Honnan'];

    $insert_query= "INSERT INTO sport(Tanc,Milyen,Honnan) VALUES('$Tanc','$Milyen','$Honnan')";
    $insert_query_run = mysqli_query($connection, $insert_query);

    if($insert_query_run)
    {
        $_SESSION['status']= "Data inserted succesfully";
        header('location: index.php');
       
    }
    else{
        $_SESSION['status']="data not inserted succesfully";
        header('location: index.php');
        
    }
}

if(isset($_POST['update_btn'])){
    $ID = $_POST['ID'];
    $Tanc = $_POST['Tanc'];
    $Milyen = $_POST['Milyen'];
    $Honnan = $_POST['Honnan'];

    $update_query = "UPDATE sport SET Tanc='$Tanc', Milyen = '$Milyen', Honnan='$Honnan' WHERE ID='$ID'";
    $update_query_run = mysqli_query($connection, $update_query);

    if($update_query_run){
        $_SESSION['status'] = "Data updated succesfully";
        header('location: index.php');
    }
    else{
        $_SESSION['status'] = "Data not updated succesfully";
        header('location: insert.php');
    }
}

    if(isset($_POST['delete_btn'])){
    $ID = $_POST['ID'];
   

    $delete_query = "DELETE FROM sport WHERE ID='$ID'";
    $delete_query_run = mysqli_query($connection, $delete_query);

    if($delete_query_run){
        $_SESSION['status'] = "Data deleted succesfully";
        header('location: index.php');
    }
    else{
        $_SESSION['status'] = "Data not deleted succesfully";
        header('location: delete.php');
    }
}
?>
