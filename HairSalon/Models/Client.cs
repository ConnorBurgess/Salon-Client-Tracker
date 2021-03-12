namespace HairSalon.Models
{
  public class Client : Salon
  {
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}