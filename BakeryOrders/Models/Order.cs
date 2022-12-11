using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title {get; set; }
    public string Description {get; set; }
    public int BreadCount {get; set; }
    public int PastryCount {get; set; }
    public string Date {get; set; }
    public int Price {get; set; }

    public Order(string title, string description, string breadCount, string pastryCount, string date)
    {
      Title = title;
      Description = description;
      BreadCount = int.Parse(breadCount);
      PastryCount = int.Parse(pastryCount);
      Date = date;
    }
  }
}