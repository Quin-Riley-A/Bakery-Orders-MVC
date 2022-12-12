using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name {get; set; }
    public string Description {get; set; }
    public List<Order> OrderList {get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      
    }

  }
}