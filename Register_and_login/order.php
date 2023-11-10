<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/water.css@2/out/water.css">
    <title>Document</title>
</head>
<body>
    
<h1>
    Gergő és Kristóf szexshopja
</h1>


<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "rendeles_oldal";

$conn = new mysqli($servername, $username, $password, $dbname);


if ($conn->connect_error) {
    die("Sikertelen kapcsolódás: " . $conn->connect_error);
}


if ($_SERVER["REQUEST_METHOD"] == "POST") {

    if (isset($_POST["termek_id"]) && isset($_POST["mennyiseg"])) {
        $termek_id = $_POST["termek_id"];
        $mennyiseg = $_POST["mennyiseg"];


        $query = "SELECT * FROM termekek WHERE id = ?";
        $stmt = $conn->prepare($query);
        $stmt->bind_param("i", $termek_id);
        $stmt->execute();
        $result = $stmt->get_result();

        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $termek_nev = $row["nev"];
            $termek_ar = $row["ar"];


            $teljes_ar = $mennyiseg * $termek_ar;


            $insert_query = "INSERT INTO rendelesek (termek_id, mennyiseg, teljes_ar, nev, cim) VALUES (?, ?, ?, ?, ?)";
            $insert_stmt = $conn->prepare($insert_query);
            $nev = $_POST["nev"];
            $cim = $_POST["cim"];
            $insert_stmt->bind_param("iisss", $termek_id, $mennyiseg, $teljes_ar, $nev, $cim);
            $insert_stmt->execute();

            echo "Rendelés sikeresen leadva!";
        } else {
            echo "Hibás termék azonosító!";
        }

        $stmt->close();
        $insert_stmt->close();
    } else {
        echo "Hiányzó adatok!";
    }
}

$query = "SELECT * FROM termekek";
$result = $conn->query($query);

if ($result->num_rows > 0) {
    while ($row = $result->fetch_assoc()) {
        echo "<p>" . $row["nev"] . " - Ár: " . $row["ar"] . " Ft ";
        echo "<form method='post' action='" . htmlspecialchars($_SERVER["PHP_SELF"]) . "'>";
        echo "<input type='hidden' name='termek_id' value='" . $row["id"] . "'>";
        echo "Mennyiség: <input type='number' name='mennyiseg' min='1' value='1'>";
        echo "Név: <input type='text' name='nev' required>";
        echo "Cím: <input type='text' name='cim' required>";
        echo "<input type='submit' value='Rendelés'>";
        echo "</form></p>";
    }
} else {
    echo "Nincsenek elérhető termékek.";
}

$conn->close();
?>

</body>
</html>
