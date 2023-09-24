using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;


namespace BakeryTracker.Tests
{

  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("title" , "description" , 7, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}
