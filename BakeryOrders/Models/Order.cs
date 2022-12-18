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
    public int OrderId {get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, string breadCount, string pastryCount, string date)
    {
      Title = title;
      Description = description;
      BreadCount = int.Parse(breadCount);
      PastryCount = int.Parse(pastryCount);
      Date = date;
      Order.OrderPrice(this);
      _instances.Add(this);
      OrderId = _instances.Count;
    }

    public static void OrderPrice(Order currentObj)
    {
      int breadPrice = ((currentObj.BreadCount/3) * 10) + (currentObj.BreadCount%3)*5;
      int pastryPrice = ((currentObj.PastryCount/3) * 5) + (currentObj.PastryCount%3)*2;
      currentObj.Price = breadPrice + pastryPrice;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}