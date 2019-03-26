namespace ADatabaseOfIceAndFire.Models
{
  public class Character
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public string Gender { get; set; }

    public string Title { get; set; }

    public bool Living { get; set; }

    public House HouseID { get; set; }
  }
}