using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderClassConstructor_InstantiatesOneOrderObj_Order()
    {
      Order newOrder = new Order("order1Title", "order1Description", "3", "3", "September 3, 1821");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderClassConstructor_ObjectValuesMatchArguments_Order()
    {
      Order newOrder = new Order("order1Title", "order1Description", "3", "3", "September 3, 1821");
      Assert.AreEqual("order1Title", newOrder.Title);
      Assert.AreEqual("order1Description", newOrder.Description);
      Assert.AreEqual(3, newOrder.BreadCount);
      Assert.AreEqual(3, newOrder.PastryCount);
      Assert.AreEqual("September 3, 1821", newOrder.Date);
    }
    [TestMethod]
    public void OrderClassConstructor_CalculatePrice_Int()
    {
      Order newOrder = new Order("order1Title", "order1Description", "3", "3", "September 3, 1821");
      Assert.AreEqual(15, newOrder.Price);
    }
  }
}