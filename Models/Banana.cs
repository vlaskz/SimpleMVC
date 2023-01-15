using System.ComponentModel.DataAnnotations;

namespace SimpleMVC.Models;

public class Banana{
    public int Id {get;set;}
    public string? Specie {get;set;}
    [DataType(DataType.Date)]
    public DateTime HarvestDate {get;set;}
    public string? Status {get;set;}
    public decimal Price {get;set;}
}