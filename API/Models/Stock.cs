namespace CineVerse.API.Models;

public sealed class Stock
{
    public int StockId { get; set; }
    public byte Quantity { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime ExitDate { get; set; }
}
