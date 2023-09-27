<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Code</title>
</head>
<body>
<?php
session_start();

if (isset($_POST['delete_btn'])) {
    $connection = mysqli_connect("localhost", "root", "", "crud");
    
    if (!$connection) {
        die("Hiba a kapcsolódás során: " . mysqli_connect_error());
    }
    
    $ID = $_POST['ID'];
    
    $delete_query = "DELETE FROM sport WHERE ID = '$ID'";
    
    if (mysqli_query($connection, $delete_query)) {
        $_SESSION['delete_message'] = "A rekord sikeresen törölve.";
    } else {
        $_SESSION['delete_message'] = "Hiba a rekord törlésekor: " . mysqli_error($connection);
    }
    
    mysqli_close($connection);
    
    header('Location: index.php'); // Visszairányítás az index.php oldalra
    exit();
}
?>


</body>
</html>