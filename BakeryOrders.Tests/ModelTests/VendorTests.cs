using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorClassConstructor_InstantiatesOneVendorObj_Vendor()
    {
      Vendor newVendor = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}