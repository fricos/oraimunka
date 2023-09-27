<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="style.css">
    <title>CRUD Project PHP-val</title>
</head>
<body>
<body>
    <div class="section">
        <div class="container">
            <div class="row">                   
                    <div class="card">
                        <div class="card-header">
                            <h4 class="fw-bold text-center" >PHP CRUD</h4>
                            <a href="insert.php" class="btn btn-primary">Adat feltöltése</a>
                        </div>
                    </div>
                    <div class="card-body">
                    <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Tánc</th>
                            <th>Milyen?</th>
                            <th>Honnan van?</th>
                            <th>Szerkesztés</th>
                            <th>Törlés</th>
                        </tr>
                    </thead>
                    <tbody>
                     <?php
                        $connection = mysqli_connect("localhost","root","","crud" );
                        $fetch_query = "SELECT * FROM sport";
                        $fetch_query_run = mysqli_query($connection,$fetch_query);
  
                        if(mysqli_num_rows($fetch_query_run) > 0)
                             {
                                 foreach($fetch_query_run as $row){
                            ?>
                            <tr>
                                <td><?php echo $row['ID']; ?></td>
                                <td><?php echo $row['Tanc']; ?></td>
                                <td><?php echo $row['Milyen']; ?></td>
                                <td><?php echo $row['Honnan']; ?></td>
                                 <td>
                                    <a class="btn btn-success" href="edit.php?ID=<?php echo $row['ID'];  ?> ">Szerkesztés</a>
                                </td>  
                                 <td>
                                        <form action="code.php" method="POST">
                                        <input type="hidden" name="ID" value="<?php echo $row['ID'];?>">
                                         <button type="submit" name="delete_btn">Delete</button>
                                        
                                        </form>
                                    </td>
                            </tr>
                                <?php
                                    }
                                    }
                                 else
                                {
                                 ?>
                                <tr>
                                    <td colspan="4">No record found</td>
                                </tr>
                                <?php
                                    }
                                 ?>   
                    </tbody>
                    </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
function myFunction() {
  alert("Hello! I am an alert box!");
}
</script>
</body>
</html>