namespace HairSalon.Models
{
  public class Client
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Description { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}