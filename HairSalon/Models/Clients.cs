namespace HairSalon.Models
{
  public class Clients
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}