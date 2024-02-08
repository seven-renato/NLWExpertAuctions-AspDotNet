namespace NLWExpert.API.Entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty; // Esta propriedade pode ser recuperada e alterada por qualquer classe externa
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    public List<Item> Items { get; set; } = [];
}
