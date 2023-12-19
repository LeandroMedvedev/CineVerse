namespace CineVerse.API.Models;

public sealed class Cart
{
    public int CartId { get; set; }
    public float Total { get; set; }
    public int Quantity { get; set; }
    public bool Paid { get; set; }
    public float Freight { get; set; }

    // relationships
    public ICollection<PhysicalMedia> PhysicalMedias { get; set; }
    public int CustomerId { get; set; }
}
