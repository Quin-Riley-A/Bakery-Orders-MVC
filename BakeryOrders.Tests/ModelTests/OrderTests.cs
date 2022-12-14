using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]

  public class OrderTests
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void ClearAll_ClearsStaticListofOrdersInstances_Void()
    {
      Order newOrder = new Order("order1Title", "order1Description", "3", "3", "September 3, 1821");
      Order.ClearAll();
      List<Order> getAllResults = Order.GetAll();
      List<Order> newTestList = new List<Order> {};
      CollectionAssert.AreEqual(newTestList, getAllResults);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllOrdersInInstanceList_OrdersList()
    {
      Order newOrder1 = new Order("order1Title", "order1Description", "3", "3", "September 3, 1821");
      Order newOrder2 = new Order("order2Title", "order2Description", "3", "3", "September 3, 1822");
      List<Order> newList = new List<Order> {newOrder1, newOrder2 };
      List<Order> getAllResults = Order.GetAll();
      Console.WriteLine(getAllResults);
      CollectionAssert.AreEqual(newList, getAllResults);
    }

  }
}