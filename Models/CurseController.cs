namespace MyIF.Models;

public class Curse
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public int Workload { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public decimal amount { get; set; }
}
