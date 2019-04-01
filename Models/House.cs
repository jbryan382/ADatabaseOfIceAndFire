using System.Collections.Generic;

namespace ADatabaseOfIceAndFire.Models
{
  public class House
  {
    public int Id { get; set; }
    public string HouseName { get; set; }
    public string HouseWords { get; set; }
    public bool Extinct { get; set; } = false;
    public string CoatOfArms { get; set; }
    public List<Character> Characters { get; set; } = new List<Character>();
  }
}