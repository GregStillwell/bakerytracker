using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("a great vendor", "Greg");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

     [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "a great vendor";
      string name = "Greg";
      Vendor newVendor = new Vendor(description, name);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Greg";
      string description = "a great vendor";
      Vendor newVendor = new Vendor(description, name);
      Assert.AreEqual(name, newVendor.Name);
    }
      [TestMethod]
     public void GetId_ReturnsId_Int()
    {
      string description = "a great vendor";
      string name = "Greg";
      Vendor newVendor = new Vendor(description, name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_List()
    {
      string description1 = "a great vendor";
      string name1 = "Greg";
      string description2 = "a great vendor";
      string name2 = "Greg";
      Vendor newVendor1 = new Vendor(description1, name1);
      Vendor newVendor2 = new Vendor(description2, name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(newList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      string description1 = "a great vendor";
      string name1 = "Greg";
      string description2 = "a great vendor";
      string name2 = "Greg";
      Vendor newVendor1 = new Vendor(description1, name1);
      Vendor newVendor2 = new Vendor(description2, name2);
      Assert.AreEqual(newVendor2, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_OrderWithVendor_OrderList()
    {
      string description1 = "a great vendor";
      string name = "Greg";
      Vendor newVendor = new Vendor(description1, name);
      string title = "new title";
      string description2 = "new description";
      int price = 7;
      string date = ("2020, 7, 1");
      Order newOrder = new Order(description2, title, price, date);
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}