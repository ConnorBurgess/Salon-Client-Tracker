using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist : Salon
  {
    public Stylist()
    {
      this.Stylists = new HashSet<Stylist>();
    }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}