namespace ADatabaseOfIceAndFire.Models
{
  public class House
  {
    public int Id { get; set; }
    public string HouseName { get; set; }
    public string HouseWords { get; set; }
    public bool Extinct { get; set; } = false;
    public Character CharacterID { get; set; }

  }
}