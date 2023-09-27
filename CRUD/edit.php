<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"> <!-- javított érték -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title>Edit</title>
</head>
<body>
    <div class="section">
        <div class="container">
            <div class="row">
                <div class="card">
                    <h4>Adat frissítése</h4>
                    <div class="card-body">
                        <?php
                        if(isset($_GET['ID'])){
                            $connection = mysqli_connect("localhost","root","","crud" );
                            $ID = $_GET['ID'];
                            $fetch_data = "SELECT * FROM sport WHERE ID='$ID'";
                            $fetch_data_run = mysqli_query($connection,$fetch_data);

                            if(mysqli_num_rows($fetch_data_run) > 0)
                            {
                                foreach($fetch_data_run as $row){
                        ?>
                        <form action="db.php" method="POST">
                            <input type="hidden" class="form-control" name="ID" value="<?php echo $row['ID'];?>">
                            <div class="mb-3">
                                <label for="Tanc" class="form-label">Tánc</label>
                                <input type="text" class="form-control" name="Tanc" value="<?php echo $row['Tanc'];?>">   
                            </div>
                            <div class="mb-3">
                                <label for="Milyen" class="form-label">Milyen?</label>
                                <input type="text" class="form-control" name="Milyen" value="<?php echo $row['Milyen'];?>">
                            </div>
                            <div class="mb-3 form-check">
                                <label for="Honnan" class="form-label">Honnan van?</label>
                                <input type="text" class="form-control" name="Honnan" value="<?php echo $row['Honnan'];?>">
                            </div>
                            <button type="submit" name="update_btn" class="btn btn-primary">Adat frissítése</button>
                        </form>
                        <?php
                            }
                        } else {                                 
                            echo "no record found"; 
                            header('location: ./index.php');
                        }
                        } else {
                            echo "something went wrong";
                            header('location: ./edit.php');
                        }
                        ?>      
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
