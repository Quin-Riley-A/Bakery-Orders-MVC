using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]

  public class VendorTests
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorClassConstructor_InstantiatesOneVendorObj_Vendor()
    {
      Vendor newVendor = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorClassConstructor_ObjectValuesMatchArguments_Vendor()
    {
      Vendor newVendor = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Assert.AreEqual("Bill's Bagels", newVendor.VendorName);
      Assert.AreEqual("Bill sells bagels and various sundries", newVendor.VendorDescription);
    }
    [TestMethod]
    public void GetAll_ReturnsListOfAllVendors_VendorsList()
    {
      Vendor newVendor = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Assert.AreEqual(typeof(List<Vendor>), Vendor.GetAll().GetType());
    }

    [TestMethod]
    public void ClearAll_ClearsVendorsInstanceList_Void()
    {
      Vendor newVendor = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Vendor.ClearAll();
      List<Vendor> getAllResults = Vendor.GetAll();
      List<Vendor> newTestList = new List<Vendor> {};
      CollectionAssert.AreEqual(newTestList, getAllResults);
    }

    [TestMethod]
    public void GetAll_ReturnsFullVendorList_VendorsList()
    {
      Vendor newVendor1 = new Vendor("Bill's Bagels", "Bill sells bagels and various sundries");
      Vendor newVendor2 = new Vendor("Bob's Beagles", "Bob  owns an animal rescue league and made a mistake...");
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
      List<Vendor> getAllResults = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, getAllResults);
    }

    [TestMethod]
    public void FindVendor_ReturnsVendorFromSpecifiedId_Vendor()
    {
      string vendorName1 = "Bill's Bagels";
      string vendorName2 = "Bob's Beagles";
      string vendorDescription1 = "Bill sells bagels and various sundries";
      string vendorDescription2 = "Bob  owns an animal rescue league and made a mistake...";

      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      Vendor foundVendor = Vendor.FindVendor(2);
      Assert.AreEqual(newVendor2, foundVendor);
    }
  }
}