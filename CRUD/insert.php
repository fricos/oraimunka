<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=.s, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title>Insert</title>
</head>
<body>
    <div class="section">
    <div class="container">
         <div class="row">
                <div class="card">
                    <h4>Adat feltöltése</h4>
                    <div class="card-body">
            <form action="db.php" method="post">
            <div class="mb-3 mt-3">
            <label for="Tanc" class="form-label">Tánc</label>
            <input type="text" class="form-control" name="Tanc">
   
            </div>
            <div class="mb-3">
                <label for="Milyen" class="form-label">Milyen?</label>
                <input type="text" class="form-control" name="Milyen">
            </div>
                <div class="mb-3">
                <label for="Honnan" class="form-label">Honnan van?</label>
                <input type="text" class="form-control" name="Honnan">
            </div>
            <button type="submit" name="insert_btn"class="btn btn-primary">Adat hozzáadása</button>
            </form>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>