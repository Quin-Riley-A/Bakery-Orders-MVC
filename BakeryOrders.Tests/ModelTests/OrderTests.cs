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
  }
}