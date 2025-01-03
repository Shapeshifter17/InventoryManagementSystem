
// var connectionString = "Server=localhost;database=IMS;Uid=root;Pwd=;Charset=utf8;Port=3306;SslMode=none";      
// using (var connection = new MySqlConnection(connectionString)){

//     var sql = "SELECT * FROM Employees";
//     var insertState = "INSERT INTO IMS.Employees(FirstName, LastName, `Role`, StartDate, OfficeLocation) VALUES('John', 'Doe', 'Engineer', '2024-10-16', 'Toronto');";
//     var newEmployee = new Employee(3,"John", "Doe", "Engineer", "Toronto", new DateTime(2024,10,16));
//     var answer = connection.Query<Employee>(sql);
//     //var rowsAffected = connection.Execute(insertState,newEmployee);
