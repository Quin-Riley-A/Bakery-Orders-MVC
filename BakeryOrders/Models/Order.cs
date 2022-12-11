using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title {get; set; }
    public string Description {get; set; }
    public int BreadCount {get; set; }
    public int PastryCount {get; set; }
    public string date {get; set; }
    private int Price {get; set; }

    public Order(string title, string description, string breadCount, string pastryCount, string date)
    {
      
    }
  }
}