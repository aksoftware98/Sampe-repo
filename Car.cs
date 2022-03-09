namespace Cars; 
public class Car 
{
    public string? Name {get; set;}
    public string? Id {get; set;}

    public CarOwner? owner { get; set; }
}

public class CarOwner
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public int Id {get; set;}
    public bool IsNotified { get; set; }
    public string? NotificationId {get; set;}

}