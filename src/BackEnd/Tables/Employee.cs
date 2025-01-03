using System.ComponentModel.DataAnnotations;

public class Employee{
    [Key]
    private int employeeID;
    private string firstName = string.Empty;
    private string LastName = string.Empty;
    private string Role = string.Empty;
    private string OfficeLocation = string.Empty;
    private DateTime StartDate;

    public Employee(int ID, string first, string last, string role, string locaiton, DateTime startDate){
        employeeID = ID;
        firstName = first;
        LastName = last;
        Role = role;
        OfficeLocation = locaiton;
        StartDate = startDate;
    } 
    public Employee(){}
    
    public override string ToString(){
        return employeeID + " " + firstName + " " + LastName;
    }
}