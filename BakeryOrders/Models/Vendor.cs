using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Vendor
  {
    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public List<Order> OrderList {get; set; }
    public int VendorId {get; set;}
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDescription = description;
      _instances.Add(this);
      VendorId = _instances.Count;
      OrderList = new List<Order>{};
      Console.WriteLine(VendorDescription);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}